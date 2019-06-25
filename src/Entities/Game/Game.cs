using GSK.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Game
{
    [Table("Games")]
    public class Game : EntityBase
    {
        public bool IsFinished { get; set; }

        public string PlayerSign { get; set; }

        public virtual ICollection<Move> Moves { get; set; }
    }
}
