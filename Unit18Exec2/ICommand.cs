using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Unit18Exec2
{
    public interface ICommand
    {
        Task Run(string url);

    }
}
