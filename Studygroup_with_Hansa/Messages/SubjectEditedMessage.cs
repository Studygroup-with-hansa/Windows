﻿using GalaSoft.MvvmLight.Messaging;
using Studygroup_with_Hansa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studygroup_with_Hansa.Messages
{
    class SubjectEditedMessage : MessageBase
    {
        public string OldName { get; set; }

        public SubjectModel Subject { get; set; }

        public SubjectEditedMessage(string name, SubjectModel subject)
        {
            OldName = name;
            Subject = subject;
        }
    }
}