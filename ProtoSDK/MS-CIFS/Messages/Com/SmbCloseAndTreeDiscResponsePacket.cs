// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using Microsoft.Protocols.TestTools.StackSdk;

namespace Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Cifs
{
    /// <summary>
    /// Packets for SmbCloseAndTreeDisc  Response
    /// </summary>
    public class SmbCloseAndTreeDiscResponsePacket : SmbSingleResponsePacket 
    {
        #region Fields

        // none

        #endregion


        #region Properties

        // none

        #endregion


        #region Constructor

        /// <summary>
        /// Constructor.
        /// </summary>
        public SmbCloseAndTreeDiscResponsePacket()
            : base()
        {
            this.InitDefaultValue();
        }


        /// <summary>
        /// Constructor: Create a request directly from a buffer.
        /// </summary>
        public SmbCloseAndTreeDiscResponsePacket(byte[] data)
            : base(data)
        {
        }


        /// <summary>
        /// Deep copy constructor.
        /// </summary>
        public SmbCloseAndTreeDiscResponsePacket(SmbCloseAndTreeDiscResponsePacket packet)
            : base(packet)
        {
            this.InitDefaultValue();
        }

        #endregion


        #region override methods

        /// <summary>
        /// to create an instance of the StackPacket class that is identical to the current StackPacket. 
        /// </summary>
        /// <returns>a new Packet cloned from this.</returns>
        public override StackPacket Clone()
        {
            return new SmbCloseAndTreeDiscResponsePacket(this);
        }


        /// <summary>
        /// encode Smb Parameters
        /// </summary>
        protected override void EncodeParameters()
        {
            this.smbParametersBlock.WordCount = 0;
            this.smbParametersBlock.Words = new ushort[0];
        }


        /// <summary>
        /// encode Smb Data
        /// </summary>
        protected override void EncodeData()
        {
            this.smbDataBlock.ByteCount = 0;
            this.smbDataBlock.Bytes = new byte[0];
        }


        /// <summary>
        /// to decode the smb parameters: from the general SmbParameters to the concrete Smb Parameters.
        /// </summary>
        protected override void DecodeParameters()
        {
        }


        /// <summary>
        /// to decode the smb data: from the general SmbDada to the concrete Smb Data.
        /// </summary>
        protected override void DecodeData()
        {
        }

        #endregion


        #region initialize fields with default value

        /// <summary>
        /// init packet, set default field data
        /// </summary>
        private void InitDefaultValue()
        {
        }

        #endregion
    }
}