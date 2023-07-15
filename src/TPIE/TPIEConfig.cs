using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPIE;

/// <summary>
/// This is the binding class of the running configuration.  
/// </summary>
public class TPIEConfig
{
    /// <summary>
    /// The location of where the database is located for the DataContext.
    /// </summary>
    public string DatabaseLocation { get; set; } = "./Database/db.db";
}
