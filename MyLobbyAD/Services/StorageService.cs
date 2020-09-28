using MyLobbyAD.Extensions;
using MyLobbyAD.Models;
using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Text;

namespace MyLobbyAD.Services
{
    class StorageService
    {
        private static IsolatedStorageFile _isoStore;
        private static UserData _data;
        public static UserData InfoData 
        {
            get
            {
                return _data;
            }
            set
            {
                _data = value;
            }
        }
        private static readonly string FILENAME = "MyLobbyAD.dat";
        public static void CreateStorage()
        {
            _isoStore = IsolatedStorageFile.GetStore(
                IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null);
            _data = new UserData();
            GetData();
        }
        public static void SetUserInfo(LoginSuccess loginSuccess)
        {
            _data.AccountId = loginSuccess.UserId;
            _data.Email = loginSuccess.Email;
            _data.Token = loginSuccess.Id;
        }
        public static void SetDate(DateTime nextUpdate)
        {
            _data.NextUpdate = nextUpdate;
        }
        public static void GetData()
        {
            _data = _isoStore.LoadObject<UserData>(FILENAME);
        }
        public static void SaveData()
        {
            _isoStore.SaveObject(_data, FILENAME);
        }
        public static bool ExistData()
        {
            return InfoData.Token != null && InfoData.AccountId != null;
        }
    }
}
