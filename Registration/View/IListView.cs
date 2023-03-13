using Registration.Model;
using System;
using System.Collections.Generic;

namespace Registration.View
{
    public interface IListView:IView
    {        
        IEnumerable<PatientModel> Patient { set; }

        void BlockEdit();
    }
}
