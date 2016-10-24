using Akavache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using System.Threading.Tasks;

namespace ShoppingCart.Services
{
    public class Cache : ICache
    {
        public Cache()
        {
            BlobCache.ApplicationName = "ShoppingCart";
        }

        public async Task<T> GetObject<T>(string key)
        {
            try
            {
                return await Task.Run(() => BlobCache.LocalMachine.GetObject<T>(key).FirstOrDefaultAsync().ToTask());
            }
            catch (KeyNotFoundException)
            {
                return default(T);
            }
        }

        public async Task InsertObject<T>(string key, T value)
        {
            await Task.Run(()=> BlobCache.LocalMachine.InsertObject(key, value));
        }

        public async Task RemoveObject(string key)
        {
            await Task.Run(() => BlobCache.LocalMachine.Invalidate(key));
        }
    }
}