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
    class FileAction : INotifyPropertyChanged
    {
        CarsList car = new CarsList();
        UsersList user = new UsersList();
        private string link;
        public FileAction() { }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public void UploadFile(string link)
        {
            this.link = link;
            string readed;
            using (FileStream stream = new FileStream(link, FileMode.Open, FileAccess.ReadWrite))
            {
                using (StreamReader streamRead = new StreamReader(stream, System.Text.Encoding.UTF8))
                {
                    readed = streamRead.ReadToEnd();
                }
            }

            string pat = @"(\n)|(\t)|(\s+)";
            Regex reg = new Regex(pat);
            readed = reg.Replace(readed, "");

            if (readed.Length != 0)
            {
                string[] mas = readed.Split(';');

                if (car.CarList != null)
                    car.CarList.Clear();
                if (user.UserList != null)
                    user.UserList.Clear();

                for (int i = 0; i < mas.Length - 1; i++)
                {
                    string[] masValue = mas[i].Split('/');
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
                car.CarList.Add(new Car
                {
                    HowCar = (Auto)Enum.Parse(typeof(Auto), masValue[1], true),
                    StateCar = (State)Enum.Parse(typeof(State), masValue[2], true),
                    AbroadCar = (Abroad)Enum.Parse(typeof(Abroad), masValue[3], true),
                    MarkCar = masValue[4],
                    ModelCar = masValue[5],
                    PriceCar = int.Parse(masValue[6].Replace(" ", "")),
                    YearCar = int.Parse(masValue[7].Replace(" ", "")),
                    EngineAmountCar = float.Parse(masValue[8].Replace(" ", "")),
                    EngineTypeCar = (EngineType)Enum.Parse(typeof(EngineType), masValue[9], true),
                    TransmissionCar = (Transmission)Enum.Parse(typeof(Transmission), masValue[10], true),
                    BodyTypeCar = (BodyType)Enum.Parse(typeof(BodyType), masValue[11], true),
                    RegionCar = (Region)Enum.Parse(typeof(Region), masValue[12], true),
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
                user.UserList.Add(new User
                {

                    Phone = masValue[1],
                    RegionUser = (Region)Enum.Parse(typeof(Region), masValue[2]),
                    City = masValue[3],
                    ReqAuto = (Auto)Enum.Parse(typeof(Auto), masValue[4]),
                    ReqMark = masValue[5],
                    MaxMoney = int.Parse(masValue[6].Replace(" ", "")),
                    ReqYear = int.Parse(masValue[7].Replace(" ", "")),
                    ReqEngineAmount = float.Parse(masValue[8].Replace(" ", "")),
                    ReqEngineType = (EngineType)Enum.Parse(typeof(EngineType), masValue[9]),
                    ReqTransmission = (Transmission)Enum.Parse(typeof(Transmission), masValue[10]),
                    ReqBodyType = (BodyType)Enum.Parse(typeof(BodyType), masValue[11]),
                    ReqState = (State)Enum.Parse(typeof(State),masValue[12])
                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void SaveFile(string newLink = "0")
        {
            if (newLink != "0")
            {
                link = newLink;
            }

            using (StreamWriter streamWriter = new StreamWriter(link))
            {
                if (car.CarList != null)
                {
                    for (int i = 0; i < car.CarList.Count; i++)
                    {
                        string s = $"[car]/{car.CarList[i].HowCar}/" +
                            $"{car.CarList[i].StateCar}/" +
                            $"{car.CarList[i].AbroadCar}/" +
                            $"{car.CarList[i].MarkCar}/" +
                            $"{car.CarList[i].ModelCar}/" +
                            $"{car.CarList[i].PriceCar}/" +
                            $"{car.CarList[i].YearCar}/ " +
                            $"{car.CarList[i].EngineAmountCar}/" +
                            $"{car.CarList[i].EngineTypeCar}/" +
                            $"{car.CarList[i].TransmissionCar}/" +
                            $"{car.CarList[i].BodyTypeCar}/ " +
                            $"{car.CarList[i].RegionCar }/ " +
                            $"{car.CarList[i].CityCar};";
                        streamWriter.WriteLine(s);
                    }
                }

                if (user.UserList != null)
                {
                    for (int i = 0; i < user.UserList.Count; i++)
                    {
                        string s = $"[user]/" +
                            $"{user.UserList[i].Phone}/" +
                            $"{user.UserList[i].RegionUser}/" +
                            $"{user.UserList[i].City}/" +
                            $"{user.UserList[i].ReqAuto}/" +
                            $"{user.UserList[i].ReqMark}/" +
                            $"{user.UserList[i].MaxMoney}/" +
                            $"{user.UserList[i].ReqYear}/ " +
                            $"{user.UserList[i].ReqEngineAmount}/" +
                            $"{user.UserList[i].ReqEngineType}/" +
                            $"{user.UserList[i].ReqTransmission}/" +
                            $"{user.UserList[i].ReqBodyType}/" +
                            $"{user.UserList[i].ReqState};";
                        streamWriter.WriteLine(s);
                    }
                }

            }

        }
    }
}