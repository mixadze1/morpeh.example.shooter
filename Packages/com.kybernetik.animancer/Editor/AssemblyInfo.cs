// Animancer // https://kybernetik.com.au/animancer // Copyright 2018-2025 Kybernetik //

using System.Diagnostics.CodeAnalysis;
using System.Reflection;

[assembly: AssemblyTitle("Kybernetik.Animancer.Editor")]
[assembly: AssemblyProduct("Animancer Pro")]
[assembly: AssemblyDescription("An animation system for Unity which is based on the Playables API.")]
[assembly: AssemblyCompany("Kybernetik")]
[assembly: AssemblyCopyright("Copyright © Kybernetik 2018-2025")]
[assembly: AssemblyVersion("8.1.1.31")]

#if UNITY_EDITOR

[assembly: SuppressMessage("Style", "IDE0039:Use local function",
    Justification = "Locals create a new delegate with each use which is less efficient and can break code.")]
[assembly: SuppressMessage("Style", "IDE0044:Make field readonly",
    Justification = "Using the [SerializeField] attribute on a private field means Unity will set it from serialized data.")]
[assembly: SuppressMessage("Code Quality", "IDE0051:Remove unused private members",
    Justification = "Unity messages can be private, but the IDE will not know that Unity can still call them.")]
[assembly: SuppressMessage("Code Quality", "IDE0052:Remove unread private members",
    Justification = "Unity messages can be private and don't need to be called manually.")]
[assembly: SuppressMessage("Style", "IDE0060:Remove unused parameter",
    Justification = "Unity messages sometimes need specific signatures, even if you don't use all the parameters.")]
[assembly: SuppressMessage("Style", "IDE0062:Make local function 'static'",
    Justification = "Not supported by Unity")]
[assembly: SuppressMessage("Style", "IDE0063:Use simple 'using' statement",
    Justification = "Not always good for implying intent.")]
[assembly: SuppressMessage("Code Quality", "IDE0067:Dispose objects before losing scope",
    Justification = "Not always relevant.")]
[assembly: SuppressMessage("Code Quality", "IDE0068:Use recommended dispose pattern",
    Justification = "Not always relevant.")]
[assembly: SuppressMessage("Code Quality", "IDE0069:Disposable fields should be disposed",
    Justification = "Not always relevant.")]

[assembly: SuppressMessage("CodeQuality", "IDE0079:Remove unnecessary suppression",
    Justification = "Don't give code style advice in publically released code.")]
[assembly: SuppressMessage("Style", "IDE1006:Naming Styles",
    Justification = "Don't give code style advice in publically released code.")]

[assembly: SuppressMessage("Correctness", "UNT0005:Suspicious Time.deltaTime usage",
    Justification = "Time.deltaTime is not suspicious in FixedUpdate, it has the same value as Time.fixedDeltaTime")]
[assembly: SuppressMessage("Type Safety", "UNT0014:Invalid type for call to GetComponent",
    Justification = "Doesn't account for generic constraints.")]
[assembly: SuppressMessage("Correctness", "UNT0029:Pattern matching with null on Unity objects",
    Justification = "Use a regular equality check if handling destroyed objects is necessary")]

[assembly: SuppressMessage("Code Quality", "CS0649:Field is never assigned to, and will always have its default value",
    Justification = "Using the [SerializeField] attribute on a private field means Unity will set it from serialized data.")]

[assembly: SuppressMessage("Microsoft.Design", "CA1001:TypesThatOwnDisposableFieldsShouldBeDisposable",
    Justification = "Having a field doesn't mean you are responsible for creating and destroying it.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly",
    Justification = "Not all events need to care about the sender.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes",
    Justification = "No need to pollute the member list of implementing types.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1063:ImplementIDisposableCorrectly",
    Justification = "No need to pollute the member list of implementing types.")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2235:MarkAllNonSerializableFields",
    Justification = "UnityEngine.Object is serializable by Unity.")]

#endif

