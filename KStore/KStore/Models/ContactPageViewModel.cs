using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KStore.Application.ViewModels.Common;

namespace KStore.Models
{
    public class ContactPageViewModel
    {
        public ContactViewModel Contact { set; get; }

        public FeedbackViewModel Feedback { set; get; }
    }
}
