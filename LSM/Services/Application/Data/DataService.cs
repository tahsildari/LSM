using LSM.Dto;
using Newtonsoft.Json;

namespace LSM.Services.Data
{
    /// <summary>
    /// Reads data from json file
    /// </summary>
    public class DataService : IDataService
    {
        public DataFile FetchData()
        {
            using (StreamReader r = new StreamReader("./Data/sv_lsm_data.json"))
            {
                string json = r.ReadToEnd();
                DataFile data = JsonConvert.DeserializeObject<DataFile>(json);
                return data;
            }
        }
    }
}
