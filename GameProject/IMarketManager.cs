using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IMarketManager
    {
        void Add(Market market);
        void Remove(Market market);
        void Update(Market market);

    }
}
