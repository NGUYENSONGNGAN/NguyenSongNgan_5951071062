using System;
using System.Reflection;

namespace NGUYENSONGNGAN_5951071062.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}