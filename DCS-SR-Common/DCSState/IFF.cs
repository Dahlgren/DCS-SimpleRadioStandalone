﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciribob.DCS.SimpleRadio.Standalone.Common.DCSState
{
    public class IFF
    {
        /**
         *  -- IFF_STATUS:  OFF = 0,  NORMAL = 1 , or IDENT = 2 (IDENT means Blink on LotATC) 
            -- M1:-1 = off, any other number on 
            -- M3: -1 = OFF, any other number on 
            -- M4: 1 = ON or 0 = OFF
            -- EXPANSION: only enabled if IFF Expansion is enabled
            -- CONTROL: 1 - OVERLAY / SRS, 0 - COCKPIT / Realistic, 2 = DISABLED / NOT FITTED AT ALL
            -- IFF STATUS{"control":1,"expansion":false,"mode1":51,"mode3":7700,"mode4":1,"status":2}
         */

        public enum IFFControlMode
        {
            COCKPIT = 0,
            OVERLAY = 1,
            DISABLED = 2
        }

        public enum IFFStatus
        {
            OFF = 0,
            NORMAL = 1,
            IDENT = 2
        }

        public IFFControlMode control = IFFControlMode.DISABLED;

        public bool expansion = false;

        public int mode1 = -1;
        public int mode3 = -1;
        public bool mode4 = false;

        public int mic = -1;

        public IFFStatus status = IFFStatus.OFF;

        public override bool Equals(object obj)
        {
            if ((obj == null) || (GetType() != obj.GetType()))
                return false;

            var compare = (IFF)obj;


            if (mode1 != compare.mode1)
            {
                return false;
            }

            if (mode3 != compare.mode3)
            {
                return false;
            }

            if (mode4 != compare.mode4)
            {
                return false;
            }

            if (status != compare.status)
            {
                return false;
            }

            return true;
        }
    }
}
