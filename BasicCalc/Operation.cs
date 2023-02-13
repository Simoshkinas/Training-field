using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalc
{
    /// <summary>
    /// Holds informatiopn about a single calculator operation
    /// </summary>
    public class Operation
    {
        #region Public propereties
        /// <summary>
        /// The left side of operation
        /// </summary>
        public string LeftSide { get; set; }

        /// <summary>
        /// The right side of operation
        /// </summary>
        public string RightSide { get; set; }
        /// <summary>
        /// The type of operation to perform
        /// </summary>
        public OperationType OperationType { get; set; }
        /// <summary>
        /// The inner operation to be performed initially
        /// </summary>
        public Operation InnerOperation { get; set; }
        #endregion
        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public Operation()
        {
            //Create empty strings instead of having nulls
            this.LeftSide = string.Empty;
            this.RightSide = string.Empty;
        }
        #endregion
    }
}
