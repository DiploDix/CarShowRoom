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
            string read;
            string pattern = @"\s{2,}";
            Regex reg = new Regex(pattern);


            using (FileStream stream = new FileStream(link, FileMode.Open, FileAccess.ReadWrite))
            {
                using (StreamReader streamRead = new StreamReader(stream, System.Text.Encoding.UTF8))
                {
                    read = streamRead.ReadToEnd();
                }
            }

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
                    HowCar = lists.ListAuto.Find(x => x.ToLower() == masValue[1].ToLower()),
                    StateCar = lists.ListState.Find(x => x.ToLower() == masValue[2].ToLower()),
                    AbroadCar = lists.ListAbroad.Find(x => x.ToLower() == masValue[3].ToLower()),
                    MarkCar = masValue[4],
                    ModelCar = masValue[5],
                    PriceCar = int.Parse(masValue[6].Replace(" ", "")),
                    YearCar = int.Parse(masValue[7].Replace(" ", "")),
                    EngineAmountCar = float.Parse(masValue[8].Replace(" ", "")),
                    EngineTypeCar = lists.ListEngineType.Find(x => x.ToLower() == masValue[9].ToLower()),
                    TransmissionCar = lists.ListTransmission.Find(x => x == masValue[10]),
                    BodyTypeCar = lists.ListBodyTypeCars.Find(x => x == masValue[11]),
                    RegionCar = lists.ListRegionCars.Find(x => x.ToLower() == masValue[12].Trim(' ').ToLower()),
                    CityCar = masValue[13]
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
                    RegionUser = lists.ListRegionCars.Find(x => x.ToLower() == masValue[2].ToLower()),
                    City = masValue[3],
                    ReqAuto = lists.ListAuto.Find(x => x.ToLower() == masValue[4].ToLower()),
                    ReqMark = masValue[5],
                    MaxMoney = int.Parse(masValue[6].Replace(" ", "")),
                    ReqYear = int.Parse(masValue[7].Replace(" ", "")),
                    ReqEngineAmount = float.Parse(masValue[8].Replace(" ", "")),
                    ReqEngineType = lists.ListEngineType.Find(x => x.ToLower() == masValue[9].ToLower()),
                    ReqTransmission = lists.ListTransmission.Find(x => x.ToLower() == masValue[10].ToLower()),
                    ReqBodyType = lists.ListBodyTypeCars.Find(x => x.ToLower() == masValue[11].ToLower()),
                    ReqState = lists.ListState.Find(x => x.ToLower() == masValue[12].ToLower())
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

            using (StreamWriter streamWriter = new StreamWriter(link))
            {
                if (carList != null)
                {
                    for (int i = 0; i < carList.Count; i++)
                    {
                        string s = $"[car]|{carList[i].HowCar}|" +
                            $"{carList[i].StateCar}|" +
                            $"{carList[i].AbroadCar}|" +
                            $"{carList[i].MarkCar}|" +
                            $"{carList[i].ModelCar}|" +
                            $"{carList[i].PriceCar}|" +
                            $"{carList[i].YearCar}| " +
                            $"{carList[i].EngineAmountCar}|" +
                            $"{carList[i].EngineTypeCar}|" +
                            $"{carList[i].TransmissionCar}|" +
                            $"{carList[i].BodyTypeCar}| " +
                            $"{carList[i].RegionCar }| " +
                            $"{carList[i].CityCar};";
                        streamWriter.WriteLine(s);
                    }
                }

                if (userList != null)
                {
                    for (int i = 0; i < userList.Count; i++)
                    {
                        string s = $"[user]|" +
                            $"{userList[i].Phone}|" +
                            $"{userList[i].RegionUser}|" +
                            $"{userList[i].City}|" +
                            $"{userList[i].ReqAuto}|" +
                            $"{userList[i].ReqMark}|" +
                            $"{userList[i].MaxMoney}|" +
                            $"{userList[i].ReqYear}| " +
                            $"{userList[i].ReqEngineAmount}|" +
                            $"{userList[i].ReqEngineType}|" +
                            $"{userList[i].ReqTransmission}|" +
                            $"{userList[i].ReqBodyType}|" +
                            $"{userList[i].ReqState};";
                        streamWriter.WriteLine(s);
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
                    string s = $"[car]|{carList[i].HowCar}|" +
                        $"{carList[i].StateCar}|" +
                        $"{carList[i].AbroadCar}|" +
                        $"{carList[i].MarkCar}|" +
                        $"{carList[i].ModelCar}|" +
                        $"{carList[i].PriceCar}|" +
                        $"{carList[i].YearCar}| " +
                        $"{carList[i].EngineAmountCar}|" +
                        $"{carList[i].EngineTypeCar}|" +
                        $"{carList[i].TransmissionCar}|" +
                        $"{carList[i].BodyTypeCar}| " +
                        $"{carList[i].RegionCar }| " +
                        $"{carList[i].CityCar};";
                    streamWriter.WriteLine(s);
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
                    string s = $"[user]|" +
                        $"{userList[i].Phone}|" +
                        $"{userList[i].RegionUser}|" +
                        $"{userList[i].City}|" +
                        $"{userList[i].ReqAuto}|" +
                        $"{userList[i].ReqMark}|" +
                        $"{userList[i].MaxMoney}|" +
                        $"{userList[i].ReqYear}| " +
                        $"{userList[i].ReqEngineAmount}|" +
                        $"{userList[i].ReqEngineType}|" +
                        $"{userList[i].ReqTransmission}|" +
                        $"{userList[i].ReqBodyType}|" +
                        $"{userList[i].ReqState};";
                    streamWriter.WriteLine(s);
                }

            }
        }

    }
}