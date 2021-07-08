using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Unit18Exec2
{
    public class Sender
    {
        ICommand _command;

        public void GetCommand(ICommand command) => this._command = command;


        public async Task Load(string url)
        {
            if (_command != null)
            {
                await _command.Run(url);
            }
        }
    }
}
