using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTreeView
{

     /// <summary>
     /// The type of a directory item
     /// </summary>
    public enum DirectoryItemType
    {
        /// <summary>
        /// A logical drive
        /// </summary>
        Drive, 
        /// <summary>
        /// A physical file
        /// </summary>
        File,

        /// <summary>
        /// A folder
        /// </summary>
        Folder
    }
}
