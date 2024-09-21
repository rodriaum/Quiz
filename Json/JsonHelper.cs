using Quiz.Objects;
using Quiz.Util.Extra;
using System.Text.Json;

namespace Quiz.Json
{
    internal class JsonHelper
    {
        public static async Task<List<T>?> GetJsonArrayList<T>(string path)
        {
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    return await JsonSerializer.DeserializeAsync<List<T>>(fs);
                }
            }
            catch (JsonException e)
            {
                await LogUtil.LogAsync("JsonException", "Could not deserialize JSON.", error: e.Message);
            }
            catch (IOException e)
            {
                await LogUtil.LogAsync("IOException", "File access error.", error: e.Message);
            }
            catch (Exception e)
            {
                await LogUtil.LogAsync("Exception", "An unexpected error occurred.", error: e.Message);
            }

            return new List<T>();
        }

        public static async Task<List<Question>?> GetJsonQuestions(string path)
        {
            return await GetJsonArrayList<Question>(path);
        }
    }
}