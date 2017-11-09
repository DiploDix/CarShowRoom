using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Text.RegularExpressions;
using CarShowRoom.Model;

namespace CarShowRoom.ViewModel
{
    class FileAction
    {
        CarsList cars = new CarsList();
        UsersList users = new UsersList();
        DefaultLists lists = new DefaultLists();

        private string link;

        public FileAction() { }

        /* Загрузка БД */
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

        void UploadCar(string[] masValue)
        {
            try
            {
                cars.CarList.Add(new Car
                {
                    HowCar = lists.ListAuto.Find(x => x.ToLower() == masValue[1].ToLower()),
                    //(Auto)Enum.Parse(typeof(Auto), masValue[1], true),
                    StateCar = lists.ListState.Find(x => x.ToLower() == masValue[2].ToLower()),
                    //StateCar = (State)Enum.Parse(typeof(State), masValue[2], true),
                    AbroadCar = lists.ListAbroad.Find(x => x.ToLower() == masValue[3].ToLower()),
                    //AbroadCar = (Abroad)Enum.Parse(typeof(Abroad), masValue[3], true),
                    MarkCar = masValue[4],
                    ModelCar = masValue[5],
                    PriceCar = int.Parse(masValue[6].Replace(" ", "")),
                    YearCar = int.Parse(masValue[7].Replace(" ", "")),
                    EngineAmountCar = float.Parse(masValue[8].Replace(" ", "")),
                    EngineTypeCar = lists.ListEngineType.Find(x => x.ToLower() == masValue[9].ToLower()),
                    //EngineTypeCar = (EngineType)Enum.Parse(typeof(EngineType), masValue[9], true),
                    TransmissionCar = lists.ListTransmission.Find(x => x == masValue[10]),
                    //TransmissionCar = (Transmission)Enum.Parse(typeof(Transmission), masValue[10], true),
                    BodyTypeCar = lists.ListBodyTypeCars.Find(x => x == masValue[11]),
                    //BodyTypeCar = (BodyType)Enum.Parse(typeof(BodyType), masValue[11], true),
                    RegionCar = lists.ListRegionCars.Find(x => x.ToLower() == masValue[12].Trim(' ').ToLower()),
                    //RegionCar = (Region)Enum.Parse(typeof(Region), masValue[12], true),
                    CityCar = masValue[13]
                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        void UploadUser(string[] masValue)
        {
            try
            {
                users.UserList.Add(new User
                {

                    Phone = masValue[1],
                    RegionUser = lists.ListRegionCars.Find(x => x.ToLower() == masValue[2].ToLower()),
                    //RegionUser = (Region)Enum.Parse(typeof(Region), masValue[2]),
                    City = masValue[3],
                    ReqAuto = lists.ListAuto.Find(x => x.ToLower() == masValue[4].ToLower()),
                    //ReqAuto = (Auto)Enum.Parse(typeof(Auto), masValue[4]),
                    ReqMark = masValue[5],
                    MaxMoney = int.Parse(masValue[6].Replace(" ", "")),
                    ReqYear = int.Parse(masValue[7].Replace(" ", "")),
                    ReqEngineAmount = float.Parse(masValue[8].Replace(" ", "")),
                    ReqEngineType = lists.ListEngineType.Find(x => x.ToLower() == masValue[9].ToLower()),
                    //ReqEngineType = (EngineType)Enum.Parse(typeof(EngineType), masValue[9]),
                    ReqTransmission = lists.ListTransmission.Find(x => x.ToLower() == masValue[10].ToLower()),
                    //ReqTransmission = (Transmission)Enum.Parse(typeof(Transmission), masValue[10]),
                    ReqBodyType = lists.ListBodyTypeCars.Find(x => x.ToLower() == masValue[11].ToLower()),
                    //ReqBodyType = (BodyType)Enum.Parse(typeof(BodyType), masValue[11]),
                    ReqState = lists.ListState.Find(x => x.ToLower() == masValue[12].ToLower())
                    //ReqState = (State)Enum.Parse(typeof(State), masValue[12])
                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void SaveFileAll(string newLink, ObservableCollection<Car> carList, ObservableCollection<User> userList)
        {
            if (!string.IsNullOrEmpty(newLink))
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