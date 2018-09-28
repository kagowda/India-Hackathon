// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace VotingData.Controllers
{
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;

    //using Microsoft.ServiceFabric.Data;
    //using Microsoft.ServiceFabric.Data.Collections;

    [Route("api/[controller]")]
    public class VoteDataController : Controller
    {
        // This is in-memory count data store : storing vote counts.
        private static ConcurrentDictionary<string, int> CountDataStore;

        // Uncomment this when you want to make this service's data reliable to crash.
        //private readonly IReliableStateManager stateManager;

        public VoteDataController()
        {
            this.InitializeCountDataStore();
        }

        void InitializeCountDataStore()
        {
            if (CountDataStore == null)
            {
                // Not handling race conditions in creating dictionary.
                CountDataStore = new ConcurrentDictionary<string, int>();
            }
        }

        // Uncomment this when you want to make this service's data reliable to crash.
        //public VoteDataController(IReliableStateManager stateManager)
        //{
        //    this.stateManager = stateManager;
        //}

        // GET api/VoteData
        [HttpGet]
        public IActionResult Get()
        {
            List<KeyValuePair<string, int>> data = new List<KeyValuePair<string, int>>(CountDataStore.Count);
            foreach (var kv in CountDataStore)
            {
                data.Add(kv);
            }
            return this.Json(data);
        }

        // PUT api/VoteData/name
        [HttpPut("{name}")]
        public IActionResult Put(string name)
        {
            CountDataStore.AddOrUpdate(name, 1, (k, v) => v + 1);
            return new OkResult();
        }

        // DELETE api/VoteData/name
        [HttpDelete("{name}")]
        public IActionResult Delete(string name)
        {
            if (!CountDataStore.ContainsKey(name))
            {
                return new NotFoundResult();
            }

            int oldValue = 0;
            if (!CountDataStore.TryRemove(name, out oldValue))
            {
                return new NotFoundResult();
            }

            return new OkResult();

            // This is how you delete keys from Service Fabric ReliableDictionary.
            // Get IReliableDictionary from StateManager.
            //IReliableDictionary<string, int> votesDictionary = await this.stateManager.GetOrAddAsync<IReliableDictionary<string, int>>("counts");

            // Create a transaction for concurrent access over multiple keys of the dictionary.
            //using (ITransaction tx = this.stateManager.CreateTransaction())
            //{
            //    if (await votesDictionary.ContainsKeyAsync(tx, name))
            //    {
            //        await votesDictionary.TryRemoveAsync(tx, name);
            //        await tx.CommitAsync();
            //        return new OkResult();
            //    }
            //    else
            //    {
            //        return new NotFoundResult();
            //    }
            //}
        }
    }
}
