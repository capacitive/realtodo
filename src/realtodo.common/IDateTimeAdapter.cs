using System;
namespace realtodo.common
{
    interface IDateTime
    {
        DateTime UtcNow { get; }
    }
}
