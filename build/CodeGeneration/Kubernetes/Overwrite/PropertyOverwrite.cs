﻿// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/kubernetes/blob/master/LICENSE

using System.Diagnostics;

namespace CodeGeneration.Kubernetes.Overwrite
{
    [DebuggerDisplay("Name: {" + nameof(Name) + "}")]
    internal class PropertyOverwrite
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public bool? Secret { get; set; }
        public char? Separator { get; set; }
        public bool? NoArgument { get; set; }
        public bool? CustomImpl { get; set; }
        public string ItemFormat { get; set; }
        public string Help { get; set; }
        public string Format { get; set; }
    }
}