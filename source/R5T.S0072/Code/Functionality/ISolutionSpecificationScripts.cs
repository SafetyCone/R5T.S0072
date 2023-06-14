using System;

using R5T.T0132;
using R5T.T0197.Extensions;


namespace R5T.S0072
{
    [FunctionalityMarker]
    public partial interface ISolutionSpecificationScripts : IFunctionalityMarker
    {
        public void Show_WebBlazorClientAndServerSolutionSpecification()
        {
            /// Inputs.
            var libraryName =
                //""
                Instances.Values.Sample_LibraryName.Value
                .ToUnadjustedLibraryName();
            // No library description needed.
            bool isPrivate = true;


            /// Run.
            var solutionSpecification = Instances.SolutionSpecificationGenerationOperations.Get_WebBlazorClientAndServerSolutionSpecification(
                libraryName,
                isPrivate);

            Console.WriteLine($"{libraryName}: library name\n{isPrivate}: private?");
            Console.WriteLine();
            Console.WriteLine($"{solutionSpecification.SolutionName}: solution name");
            Console.WriteLine($"{solutionSpecification.BlazorClientProjectSpecification.ProjectName}: Blazor client project name");
            Console.WriteLine($"{solutionSpecification.BlazorClientProjectSpecification.ProjectDescription}: Blazor client project description");
            Console.WriteLine($"{solutionSpecification.ServerProjectSpecification.ProjectName}: server project name");
            Console.WriteLine($"{solutionSpecification.ServerProjectSpecification.ProjectDescription}: server project description");
        }
    }
}
