using System;
using EVEMon.Common.Models;

namespace EVEMon.Common.CustomEventArgs
{
    public sealed class CharacterIdentityChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="identity"></param>
        public CharacterIdentityChangedEventArgs(CharacterIdentity identity)
        {
            CharacterIdentity = identity;
        }

        /// <summary>
        /// Gets the character identity related to this event.
        /// </summary>
        public CharacterIdentity CharacterIdentity { get; }
    }
}