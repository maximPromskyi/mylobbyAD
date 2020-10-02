using MyLobbyAD.Extensions;
using MyLobbyAD.Models;
using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
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
            try
            {
                GetData();
            }
            catch
            {
                SaveData();
            }
        }
        public static void SetUserInfo(LoginSuccess loginSuccess)
        {
            _data.AccountId = loginSuccess.UserId;
            _data.Email = loginSuccess.Email;
            _data.Token = loginSuccess.Id;
        }
        public static void SetDateInfo(DateTime nextUpdate, string key)
        {
            _data.NextUpdate = nextUpdate;
            _data.Key = key;
            SaveData();
        }
        public static void SetPreviousUpdate(DateTime previousUpdate)
        {
            _data.PreviousUpdate = previousUpdate;
            SaveData();
        }
        public static void SetInfoSyncs(Dictionary<Guid, bool> infoSyncs)
        {
            _data.InfoSyncs = infoSyncs;
            SaveData();
        }
        public static void RemoveInfoSyncs(List<Guid> usersId)
        {
            List<Guid> usersIdRemove = _data.InfoSyncs
                .Where(data => !usersId.Contains(data.Key))
                .Select(data => data.Key)
                .ToList();
            foreach (var userId in usersIdRemove)
            {
                _data.InfoSyncs.Remove(userId);
            }
        }
        public static void UpdateInfoSyncs(List<Guid> usersId)
        {
            if (_data.InfoSyncs == null)
            {
                _data.InfoSyncs = new Dictionary<Guid, bool>();
            }
            else
            {
                RemoveInfoSyncs(usersId);
            }
            foreach (var userId in usersId)
            {
                if (!_data.InfoSyncs.ContainsKey(userId))
                {
                    _data.InfoSyncs.Add(userId, true);
                }
            }
            SaveData();
        }
        public static void SetPropetiesAD(Dictionary<string, bool> propertiesAD)
        {
            _data.PropertiesAD = propertiesAD;
            SaveData();
        }
        public static string GetStrPreviousUpdate()
        {
            if (_data.PreviousUpdate == new DateTime())
            {
                return "Last update: unknown";
            }
            return $"Last update: {_data.PreviousUpdate}";
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
        public static void RemoveData()
        {
            _data = new UserData();
            SaveData();
        }
        public static void RemoveDateInfo()
        {
            _data.NextUpdate = new DateTime();
            _data.Key = null;
            SaveData();
        }
    }
}
