using Newtonsoft.Json;
using System;

namespace SnakeEyesGame.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class SnakeEyes
    {
        #region Fields
        [JsonProperty]
        private readonly Dice _eye1;
        [JsonProperty]
        private readonly Dice _eye2;
        #endregion

        #region Properties
        [JsonProperty]
        public int Total { get; private set; }
        public int Eye1 => _eye1.Pips;
        public int Eye2 => _eye2.Pips;
        public bool HasSnakeEyes => Eye1 == 1 && Eye2 == 1;
        #endregion

        #region Constructor
        public SnakeEyes()
        {
            _eye1 = new Dice();
            _eye2 = new Dice();
            Total = 0;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Rolls the dices. Calculates the total.
        /// </summary>
        public void Play()
        {
            _eye1.Roll();
            _eye2.Roll();
            Total = HasSnakeEyes ? 0 : Total + Eye1 + Eye2;
        }
        #endregion
    }
}