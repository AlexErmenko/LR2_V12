using System;
using InstituteDepartment.Domain.Helpers;
using InstituteDepartment.Domain.Main;

namespace InstituteDepartment.Domain.EnumerableTypes
{
    [Serializable]
    public partial class SubjectList : ObservableListSource<Subject>
    {

    }
}