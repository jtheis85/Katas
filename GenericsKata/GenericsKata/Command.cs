using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsKata
{
  public class Command<T,U> 
    where T : Officer
    where U : Officer
  {
    public T Captain { get; set; }
    public U FirstMate { get; set; }
  }
}
