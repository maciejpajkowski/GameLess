using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLess
{
    public class SessionModel
    {
        /// <summary>
        /// Unique identifier for a single session.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Date at which the session occurred.
        /// </summary>
        public DateTime SessionDate { get; set; }
        /// <summary>
        /// The length of the session.
        /// </summary>
        public DateTime SessionLength { get; set; }

    }
}
