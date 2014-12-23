using System;
using System.Threading.Tasks;

namespace CSharpNewFeatures.Legacy
{
    public class Picture
    {
        public async Task PrintAsync()
        {
            try
            {
                await DoSomethingAsync();
            }
            catch (ConfigurationException ex)
            {
                if (ex.IsSevere)
                {
                    // await LogAsync(ex); // C# 5.0 中编译错误
                    LogAsync(ex).Wait();
                }
            }
            finally
            {
                // await CloseAsync(); // C# 5.0 中编译错误
                CloseAsync().Wait();
            }
        }

        protected Task DoSomethingAsync()
        {
            return Task.Run(() =>
            {
                // ...
            });
        }

        protected Task LogAsync(Exception ex)
        {
            return Task.Run(() =>
            {
                // ...
            });
        }

        public Task CloseAsync()
        {
            return Task.Run(() =>
            {
                // ...
            });
        }
    }
}
