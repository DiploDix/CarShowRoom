using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Text.RegularExpressions;
using CarShowRoom.Model;

namespace CarShowRoom.ViewModel
{
    /// <summary>
    /// Работа с файлом txt
    /// </summary>
    class FileAction
    {
        CarsList cars = new CarsList();
        UsersList users = new UsersList();
        DefaultLists lists = new DefaultLists();

        private string link; // ссылка на предыдущий файл

        public FileAction() { }

        /* Загрузка с файла коллекций автомобиля или пользователя */
        public void UploadFile(string link)
        {
            this.link = link;
            string pattern = @"\s{2,}";
            Regex reg = new Regex(pattern);

            string read = File.ReadAllText(link);
            read = reg.Replace(read, "");

            if (read.Length != 0)
            {
                string[] mas = read.Split(';');

                if (cars.CarList != null)
                    cars.CarList.Clear();
                if (users != null)
                    users.UserList.Clear();

                for (int i = 0; i < mas.Length - 1; i++)
                {
                    string[] masValue = mas[i].Split('|');
                    switch (masValue[0].ToLower())
                    {
                        case "[car]":
                            UploadCar(masValue);
                            break;
                        case "[user]":
                            UploadUser(masValue);
                            break;
                    }
                }

            }
        }

        /* Запись автомобилей в коллекцию */
        void UploadCar(string[] masValue)
        {
            try
            {
                cars.CarList.Add(new Car
                {
                    UsedOrNewCar = lists.ListUsedOrNewCar.Find(x => x.ToLower() == masValue[1].ToLower()),
                    ProductionCar = lists.ListProduction.Find(x => x.ToLower() == masValue[2].ToLower()),
                    MarkCar = masValue[3].Trim(' '),
                    ModelCar = masValue[4].Trim(' '),
                    BodyTypeCar = lists.ListBodyType.Find(x => x == masValue[5]),
                    YearCar = int.Parse(masValue[6].Replace(" ", "")),
                    PriceCar = int.Parse(masValue[7].Replace(" ", "")),
                    RegionCar = lists.ListRegion.Find(x => x.ToLower() == masValue[8].Trim(' ').ToLower()),
                    CityCar = masValue[9],
                    EngineAmountCar = float.Parse(masValue[10].Replace(" ", "")),
                    TransmissionCar = lists.ListTransmission.Find(x => x == masValue[11]),
                    FuelCar = lists.ListFuelType.Find(x => x.ToLower() == masValue[12].ToLower()),
                    StateCar = lists.ListState.Find(x => x.ToLower() == masValue[13].ToLower()),
                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /* Запись пользователей в коллекцию */
        void UploadUser(string[] masValue)
        {
            try
            {
                users.UserList.Add(new User
                {

                    Phone = masValue[1],
                    UsedOrNewUser = lists.ListUsedOrNewCar.Find(x => x.ToLower() == masValue[2].ToLower()),
                    ProductionUser = lists.ListProduction.Find(x => x.ToLower() == masValue[3].ToLower()),
                    MarkUser = masValue[4],
                    ModelUser = masValue[5],
                    BodyTypeUser = lists.ListBodyType.Find(x => x == masValue[6]),
                    YearMinUser = int.Parse(masValue[7].Replace(" ", "")),
                    YearMaxUser = int.Parse(masValue[8].Replace(" ", "")),
                    PriceMinUser = int.Parse(masValue[9].Replace(" ", "")),
                    PriceMaxUser = int.Parse(masValue[10].Replace(" ", "")),
                    RegionUser = lists.ListRegion.Find(x => x.ToLower() == masValue[11].Trim(' ').ToLower()),
                    CityUser = masValue[12],
                    EngineAmountMinUser = float.Parse(masValue[13].Replace(" ", "")),
                    EngineAmountMaxUser = float.Parse(masValue[14].Replace(" ", "")),
                    TransmissionUser = lists.ListTransmission.Find(x => x == masValue[15]),
                    FuelUser = lists.ListFuelType.Find(x => x.ToLower() == masValue[16].ToLower()),
                    StateUser = lists.ListState.Find(x => x.ToLower() == masValue[17].ToLower()),
                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /* Сохраняет коллекции автомобилей и пользователей в один файл */
        public void SaveFileAll(string newLink, ObservableCollection<Car> carList, ObservableCollection<User> userList)
        {
            if (newLink != "current")
                link = newLink;

            if (String.IsNullOrEmpty(link))
                return;

            using (StreamWriter streamWriter = new StreamWriter(link))
            {
                if (carList != null)
                {
                    for (int i = 0; i < carList.Count; i++)
                    {
                        string carString = $"[car]|{carList[i].UsedOrNewCar}|" +
                            $"{carList[i].ProductionCar}|" +
                            $"{carList[i].MarkCar}|" +
                            $"{carList[i].ModelCar}|" +
                            $"{carList[i].BodyTypeCar}|" +
                            $"{carList[i].YearCar}|" +
                            $"{carList[i].PriceCar}|" +
                            $"{carList[i].RegionCar}|" +
                            $"{carList[i].CityCar}|" +
                            $"{carList[i].EngineAmountCar}|" +
                            $"{carList[i].TransmissionCar}|" +
                            $"{carList[i].FuelCar}|" +
                            $"{carList[i].StateCar};";

                        streamWriter.WriteLine(carString);
                    }
                }

                if (userList != null)
                {
                    for (int i = 0; i < userList.Count; i++)
                    {
                        string userString = $"[user]|{userList[i].Phone}|" +
                            $"{userList[i].UsedOrNewUser}|" +
                            $"{userList[i].ProductionUser}| " +
                            $"{userList[i].MarkUser}|" +
                            $"{userList[i].ModelUser}|" +
                            $"{userList[i].BodyTypeUser}|"+
                            $"{userList[i].YearMinUser}|" +
                            $"{userList[i].YearMaxUser}|" +
                            $"{userList[i].PriceMinUser}|" +
                            $"{userList[i].PriceMaxUser}|" +
                            $"{userList[i].RegionUser}|" +
                            $"{userList[i].CityUser}|" +
                            $"{userList[i].EngineAmountMinUser}|" +
                            $"{userList[i].EngineAmountMaxUser}|" +
                            $"{userList[i].TransmissionUser}|" +
                            $"{userList[i].FuelUser}|" +
                            $"{userList[i].StateUser};";

                        streamWriter.WriteLine(userString);
                    }


                }
            }

        }

        /* Сохраняет коллекцию автомобилей */
        public void SaveFileCar(string linkFile, ObservableCollection<Car> carList)
        {
            using (StreamWriter streamWriter = new StreamWriter(linkFile))
            {
                for (int i = 0; i < carList.Count; i++)
                {
                    string carString = $"[car]|{carList[i].UsedOrNewCar}|" +
                        $"{carList[i].ProductionCar}| " +
                        $"{carList[i].MarkCar}|" +
                        $"{carList[i].ModelCar}|" +
                        $"{carList[i].YearCar}|" +
                        $"{carList[i].PriceCar}|" +
                        $"{carList[i].RegionCar}|" +
                        $"{carList[i].CityCar}|" +
                        $"{carList[i].EngineAmountCar}|" +
                        $"{carList[i].TransmissionCar}|" +
                        $"{carList[i].FuelCar}|" +
                        $"{carList[i].StateCar};";

                    streamWriter.WriteLine(carString);
                }
            }
        }

        /* Сохраняет коллекцию пользователей */
        public void SaveFileUser(string linkFile, ObservableCollection<User> userList)
        {
            using (StreamWriter streamWriter = new StreamWriter(linkFile))
            {
                for (int i = 0; i < userList.Count; i++)
                {
                    string userString = $"[car]|{userList[i].Phone}" +
                        $"{userList[i].UsedOrNewUser}|" +
                        $"{userList[i].ProductionUser}|" +
                        $"{userList[i].MarkUser}|" +
                        $"{userList[i].ModelUser}|" +
                        $"{userList[i].YearMinUser}|" +
                        $"{userList[i].YearMaxUser}|" +
                        $"{userList[i].PriceMinUser}|" +
                        $"{userList[i].PriceMaxUser}|" +
                        $"{userList[i].RegionUser}|" +
                        $"{userList[i].CityUser}|" +
                        $"{userList[i].EngineAmountMinUser}|" +
                        $"{userList[i].EngineAmountMaxUser}|" +
                        $"{userList[i].TransmissionUser}|" +
                        $"{userList[i].FuelUser}|" +
                        $"{userList[i].StateUser};";

                    streamWriter.WriteLine(userString);
                }

            }
        }

    }
}