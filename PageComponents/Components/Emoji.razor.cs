namespace PageComponents.Components;

using Microsoft.AspNetCore.Components;
public partial class Emoji
{
    [Parameter] public string EmojiChar { get; set; } = "";
    [Parameter] public string Class { get; set; } = "";
    [Parameter] public string Style { get; set; } = "";
    [Parameter] public bool Shadow { get; set; } = false;
    [Parameter] public int Level { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }
}