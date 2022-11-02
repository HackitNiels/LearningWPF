using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningWPF.MVVM.ViewModel
{
    public interface IViewModel 
    {
        string Name { get; }
        bool IsActive { get; set; }
    }
}
