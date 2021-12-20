using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary.Sets
{
    //https://leetcode.com/problems/accounts-merge/
    public class AccountsMerge
    {
        public IList<IList<string>> MergeAccounts(IList<IList<string>> accounts)
        {
            int i = 0;
            while (i < accounts.Count)
            {
                for (int j = i + 1; j < accounts.Count; j++)
                {
                    if (HasSameOwner(accounts[i], accounts[j]))
                    {
                        AddEmailAddresses(accounts[i], accounts[j]);
                        accounts[i] = accounts[i].OrderBy(x => x).ToList();
                        accounts.Remove(accounts[j]);
                        i++;
                        break;
                    }
                }
                i++;
            }
            return accounts;
        }

        private void AddEmailAddresses(IList<string> account1, IList<string> account2)
        {
            for (int i = 1; i < account2.Count; i++) //Add emails from account2
            {
                account1.Add(account2[i]);
            }
        }

        private bool HasSameOwner(IList<string> account1, IList<string> account2)
        {
            if (account1[0] != account2[0])
            {
                return false;
            }
            for (int i = 1; i < account1.Count - 1; i++)
            {
                for (int j = 1; j < account2.Count; j++)
                {
                    if (account1[i] == account2[j])
                    {
                        account2.RemoveAt(j);
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
