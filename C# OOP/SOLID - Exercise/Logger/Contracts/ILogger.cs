﻿using Logger.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Contracts
{
    public interface ILogger
    {
        ICollection<IAppender> Appenders { get; }

        void Log(IMessage message);
    }
}