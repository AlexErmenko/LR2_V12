using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using InstituteDepartment.Domain.Helpers;
using InstituteDepartment.Domain.Main;

namespace InstituteDepartment.Domain.EnumerableTypes
{
    [Serializable]
    public class TeacherList : ObservableListSource<Teacher>
    {

    }
}