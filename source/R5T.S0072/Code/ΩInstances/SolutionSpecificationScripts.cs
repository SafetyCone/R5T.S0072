using System;


namespace R5T.S0072
{
    public class SolutionSpecificationScripts : ISolutionSpecificationScripts
    {
        #region Infrastructure

        public static ISolutionSpecificationScripts Instance { get; } = new SolutionSpecificationScripts();


        private SolutionSpecificationScripts()
        {
        }

        #endregion
    }
}
