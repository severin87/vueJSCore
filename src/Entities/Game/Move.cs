using GSK.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Game
{
    [Table("Moves")]
    public class Move : AuditableEntityBase
    {
        public Guid GameId { get; set; }

        [ForeignKey("GameId")]
        public virtual Game Game { get; set; }

        public MovePosition Position  { get; set; }

        public int Order { get; set; }

        public bool IsPlayer { get; set; }
    }
}
