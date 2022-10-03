using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Infrastructure
{
    public class KeyCommands
    {
        public Dictionary<ConsoleKey, MatrixMovement> Move { get; set; } = new Dictionary<ConsoleKey, MatrixMovement>()
        {
            { ConsoleKey.W,new MatrixMovement{ColMovement = 0, RowMovement = -1} },
            { ConsoleKey.S,new MatrixMovement{ColMovement = 0, RowMovement = +1} },
            { ConsoleKey.A,new MatrixMovement{ColMovement = -1, RowMovement = 0} },
            { ConsoleKey.D,new MatrixMovement{ColMovement = +1, RowMovement = 0} },
            { ConsoleKey.E,new MatrixMovement{ColMovement = +1, RowMovement = -1} },
            { ConsoleKey.X,new MatrixMovement{ColMovement = +1, RowMovement = +1} },
            { ConsoleKey.Q,new MatrixMovement{ColMovement = -1, RowMovement = -1} },
            { ConsoleKey.Z,new MatrixMovement{ColMovement = -1, RowMovement = +1} },

        };
    }
}
