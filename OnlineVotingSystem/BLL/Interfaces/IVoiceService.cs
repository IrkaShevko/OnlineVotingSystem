﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineVotingSystem.BLL.Interfaces
{
    public interface IVoiceService
    {
        void Vote(int userId, int variantId);
    }
}
