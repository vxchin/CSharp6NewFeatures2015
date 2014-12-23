using System;
using System.Threading.Tasks;

namespace CSharpNewFeatures
{
    public class Picture
    {
        public async Task PrintAsync()
        {
            try
            {
                await DoSomethingAsync();
            }
            catch (ConfigurationException ex) if (ex.IsSevere)
            {
                await LogAsync(ex);
            }
            finally
            {
                await CloseAsync();
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
