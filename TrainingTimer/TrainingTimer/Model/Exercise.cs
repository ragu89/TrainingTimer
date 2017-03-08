using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTimer.Model
{ 
    public class Exercise
    {
        /// <summary>
        /// The name of the exercise
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The description of the excerise
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The number of repetiton of the exercise
        /// </summary>
        public int RepetitionNumber { get; set; }

        /// <summary>
        /// The duration of the exercice in seconds
        /// </summary>
        public float Duration { get; set; }
    }
}
