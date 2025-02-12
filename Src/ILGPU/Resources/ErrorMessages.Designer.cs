﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ILGPU.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ErrorMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ErrorMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ILGPU.Resources.ErrorMessages", typeof(ErrorMessages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The assembly version &apos;{0}&apos; is not compatible with the current version &apos;{1}&apos;.
        /// </summary>
        internal static string AssemblyVersionNotCompatible {
            get {
                return ResourceManager.GetString("AssemblyVersionNotCompatible", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Duplicate node id &apos;{0}&apos; detected.
        /// </summary>
        internal static string CannotDeserializeDuplicateNodeId {
            get {
                return ResourceManager.GetString("CannotDeserializeDuplicateNodeId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find the field &apos;{0}&apos; of type &apos;{1}&apos;.
        /// </summary>
        internal static string CannotFindFieldOfType {
            get {
                return ResourceManager.GetString("CannotFindFieldOfType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not supported on this device..
        /// </summary>
        internal static string CapabilityNotSupported {
            get {
                return ResourceManager.GetString("CapabilityNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not supported on this device. Requires {1} or higher..
        /// </summary>
        internal static string CapabilityNotSupportedCuda {
            get {
                return ResourceManager.GetString("CapabilityNotSupportedCuda", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The context flags &apos;{0}&apos; of the deserialized context are not compatible with the current flags &apos;{1}&apos;.
        /// </summary>
        internal static string ContextFlagsAreNotCompatible {
            get {
                return ResourceManager.GetString("ContextFlagsAreNotCompatible", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not load method &apos;{0}&apos;.
        /// </summary>
        internal static string CouldNotDeserializeMethod {
            get {
                return ResourceManager.GetString("CouldNotDeserializeMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not load type &apos;{0}&apos;.
        /// </summary>
        internal static string CouldNotDeserializeType {
            get {
                return ResourceManager.GetString("CouldNotDeserializeType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find IR method that corresponds to the method handle &apos;{0}&apos;.
        /// </summary>
        internal static string CouldNotFindCorrespondingIRMethod {
            get {
                return ResourceManager.GetString("CouldNotFindCorrespondingIRMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}. Ensure type is publicly visible, or internally visible and define &apos;[assembly: System.Runtime.CompilerServices.InternalsVisibleToAttribute(&quot;{1}&quot;)]&apos;..
        /// </summary>
        internal static string CouldNotLoadType {
            get {
                return ResourceManager.GetString("CouldNotLoadType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Method &apos;{0}&apos; has custom exception semantics..
        /// </summary>
        internal static string CustomExceptionSemantics {
            get {
                return ResourceManager.GetString("CustomExceptionSemantics", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An internal compiler error has been detected.
        /// </summary>
        internal static string InternalCompilerError {
            get {
                return ResourceManager.GetString("InternalCompilerError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid null value.
        /// </summary>
        internal static string InternalCompilerErrorNull {
            get {
                return ResourceManager.GetString("InternalCompilerErrorNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dynamic shared memory elements specified but the kernel does not support dynamic shared memory bindings.
        /// </summary>
        internal static string InvalidDynamicSharedMemoryConfiguration {
            get {
                return ResourceManager.GetString("InvalidDynamicSharedMemoryConfiguration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An entry point must receive at least one index parameter.
        /// </summary>
        internal static string InvalidEntryPointIndexParameter {
            get {
                return ResourceManager.GetString("InvalidEntryPointIndexParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An implicitly grouped entry point must receive an int index type as first parameter, long indices are not supported..
        /// </summary>
        internal static string InvalidEntryPointIndexParameterOfWrongType {
            get {
                return ResourceManager.GetString("InvalidEntryPointIndexParameterOfWrongType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only static methods and non-capturing lambdas are supported at the moment.
        /// </summary>
        internal static string InvalidEntryPointInstanceKernelMethod {
            get {
                return ResourceManager.GetString("InvalidEntryPointInstanceKernelMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not supported by-ref kernel parameter.
        /// </summary>
        internal static string InvalidEntryPointParameter {
            get {
                return ResourceManager.GetString("InvalidEntryPointParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not supported entry point without a valid .Net runtime entry.
        /// </summary>
        internal static string InvalidEntryPointWithoutDotNetMethod {
            get {
                return ResourceManager.GetString("InvalidEntryPointWithoutDotNetMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid IL Code.
        /// </summary>
        internal static string InvalidILCode {
            get {
                return ResourceManager.GetString("InvalidILCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This operation can only be called from an ILGPU kernel.
        /// </summary>
        internal static string InvalidKernelOperation {
            get {
                return ResourceManager.GetString("InvalidKernelOperation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -.
        /// </summary>
        internal static string LocationCompilationStackLinePrefix {
            get {
                return ResourceManager.GetString("LocationCompilationStackLinePrefix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} in file &apos;{1}&apos;, line {2} column {3}.
        /// </summary>
        internal static string LocationFileMessageL1C1 {
            get {
                return ResourceManager.GetString("LocationFileMessageL1C1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} in file &apos;{1}&apos;, line {2} column {3} to {4}.
        /// </summary>
        internal static string LocationFileMessageL1C2 {
            get {
                return ResourceManager.GetString("LocationFileMessageL1C2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} in file &apos;{1}&apos;, line {2} column {3} to line {4} column {5}.
        /// </summary>
        internal static string LocationFileMessageL2C2 {
            get {
                return ResourceManager.GetString("LocationFileMessageL2C2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} in method {1} declared in type {2}.
        /// </summary>
        internal static string LocationMethodMessage {
            get {
                return ResourceManager.GetString("LocationMethodMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; related to type {1} (managed type &apos;{2}&apos;).
        /// </summary>
        internal static string LocationTypeMessage {
            get {
                return ResourceManager.GetString("LocationTypeMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Native method &apos;{0}&apos; is not supported.
        /// </summary>
        internal static string NativeMethodNotSupported {
            get {
                return ResourceManager.GetString("NativeMethodNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This operation is only permitted in native-OS-platform mode. The current runtime is &apos;{0}&apos; but the native OS platform is &apos;{1}&apos;.
        /// </summary>
        internal static string NativePlatformInvocationRequired {
            get {
                return ResourceManager.GetString("NativePlatformInvocationRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The operation &apos;{0}&apos; on the .Net activator is not supported..
        /// </summary>
        internal static string NotSupportedActivatorOperation {
            get {
                return ResourceManager.GetString("NotSupportedActivatorOperation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not supported arithmetic operands &apos;{0}&apos; &amp; &apos;{1}&apos;.
        /// </summary>
        internal static string NotSupportedArithmeticOperandTypes {
            get {
                return ResourceManager.GetString("NotSupportedArithmeticOperandTypes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot create a dynamically sized array on an accelerator.
        /// </summary>
        internal static string NotSupportedArrayCreation {
            get {
                return ResourceManager.GetString("NotSupportedArrayCreation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The array dimension &apos;{0}&apos; is out of the supported array dimensions..
        /// </summary>
        internal static string NotSupportedArrayDimension {
            get {
                return ResourceManager.GetString("NotSupportedArrayDimension", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not supported by-ref kernel parameters.
        /// </summary>
        internal static string NotSupportedByRefKernelParameters {
            get {
                return ResourceManager.GetString("NotSupportedByRefKernelParameters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Class type &apos;{0}&apos; is not supported.
        /// </summary>
        internal static string NotSupportedClassType {
            get {
                return ResourceManager.GetString("NotSupportedClassType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; is not supported in the scope of this compare operation.
        /// </summary>
        internal static string NotSupportedCompareArgumentType {
            get {
                return ResourceManager.GetString("NotSupportedCompareArgumentType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not supported compare or arithmetic value of type &apos;{0}&apos;.
        /// </summary>
        internal static string NotSupportedCompareOrArithmeticValue {
            get {
                return ResourceManager.GetString("NotSupportedCompareOrArithmeticValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot convert from &apos;{0}&apos; to type &apos;{1}&apos;.
        /// </summary>
        internal static string NotSupportedConversion {
            get {
                return ResourceManager.GetString("NotSupportedConversion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Delegate type &apos;{0}&apos; is not supported.
        /// </summary>
        internal static string NotSupportedDelegateType {
            get {
                return ResourceManager.GetString("NotSupportedDelegateType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The allocation size of type &apos;{0}&apos; must be statically known and not a dynamic value.
        /// </summary>
        internal static string NotSupportedDynamicAllocation {
            get {
                return ResourceManager.GetString("NotSupportedDynamicAllocation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dynamic shared memory allocations are not supported by this accelerator.
        /// </summary>
        internal static string NotSupportedDynamicSharedMemoryAllocations {
            get {
                return ResourceManager.GetString("NotSupportedDynamicSharedMemoryAllocations", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot cast type &apos;{0}&apos; to float/int.
        /// </summary>
        internal static string NotSupportedFloatIntCast {
            get {
                return ResourceManager.GetString("NotSupportedFloatIntCast", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not supported IL instruction of type &apos;{0}&apos;.
        /// </summary>
        internal static string NotSupportedILInstruction {
            get {
                return ResourceManager.GetString("NotSupportedILInstruction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not supported IL instruction in method &apos;{0}&apos;. Are you using a lambda closure?.
        /// </summary>
        internal static string NotSupportedILInstructionPossibleLambda {
            get {
                return ResourceManager.GetString("NotSupportedILInstructionPossibleLambda", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not supported indirect call to a method with the signature &apos;{0}&apos;.
        /// </summary>
        internal static string NotSupportedIndirectMethodCall {
            get {
                return ResourceManager.GetString("NotSupportedIndirectMethodCall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not supported inline PTX format &apos;{0}&apos;.
        /// </summary>
        internal static string NotSupportedInlinePTXFormat {
            get {
                return ResourceManager.GetString("NotSupportedInlinePTXFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not supported inline PTX format argument reference &apos;{1}&apos; in &apos;{0}&apos;.
        /// </summary>
        internal static string NotSupportedInlinePTXFormatArgumentRef {
            get {
                return ResourceManager.GetString("NotSupportedInlinePTXFormatArgumentRef", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not supported inline PTX format argument type &apos;{1} in &apos;{0}&apos;.
        /// </summary>
        internal static string NotSupportedInlinePTXFormatArgumentType {
            get {
                return ResourceManager.GetString("NotSupportedInlinePTXFormatArgumentType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not supported inline PTX format &apos;{0}; must be a constant string reference.
        /// </summary>
        internal static string NotSupportedInlinePTXFormatConstant {
            get {
                return ResourceManager.GetString("NotSupportedInlinePTXFormatConstant", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not supported instruction &apos;{0}&apos; in method &apos;{1}&apos;..
        /// </summary>
        internal static string NotSupportedInstruction {
            get {
                return ResourceManager.GetString("NotSupportedInstruction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Interface type &apos;{0}&apos; is not supported.
        /// </summary>
        internal static string NotSupportedInterfaceType {
            get {
                return ResourceManager.GetString("NotSupportedInterfaceType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The interop intrinsic &apos;{0}&apos; is not supported.
        /// </summary>
        internal static string NotSupportedInteropIntrinsic {
            get {
                return ResourceManager.GetString("NotSupportedInteropIntrinsic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not supported int operand of type &apos;{0}&apos;.
        /// </summary>
        internal static string NotSupportedIntOperand {
            get {
                return ResourceManager.GetString("NotSupportedIntOperand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not supported intrinsic type &apos;{0}&apos;.
        /// </summary>
        internal static string NotSupportedIntrinsic {
            get {
                return ResourceManager.GetString("NotSupportedIntrinsic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A function does not have an intrinsic implementation for this backend. &apos;EnableAlgorithms&apos; from the Algorithms library not invoked?.
        /// </summary>
        internal static string NotSupportedIntrinsicImplementation0 {
            get {
                return ResourceManager.GetString("NotSupportedIntrinsicImplementation0", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The function &apos;{0}&apos; does not have an intrinsic implementation for this backend. &apos;EnableAlgorithms&apos; from the Algorithms library not invoked?.
        /// </summary>
        internal static string NotSupportedIntrinsicImplementation1 {
            get {
                return ResourceManager.GetString("NotSupportedIntrinsicImplementation1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IsInstance is currently not supported.
        /// </summary>
        internal static string NotSupportedIsInstance {
            get {
                return ResourceManager.GetString("NotSupportedIsInstance", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not supported kernel-parameter type &apos;{0}&apos;.
        /// </summary>
        internal static string NotSupportedKernelParameterType {
            get {
                return ResourceManager.GetString("NotSupportedKernelParameterType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The language intrinsic &apos;{0}&apos; is not supported.
        /// </summary>
        internal static string NotSupportedLanguageIntrinsic {
            get {
                return ResourceManager.GetString("NotSupportedLanguageIntrinsic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot load from the static array &apos;{0} since it is mutable..
        /// </summary>
        internal static string NotSupportedLoadFromStaticArray {
            get {
                return ResourceManager.GetString("NotSupportedLoadFromStaticArray", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot load from the static field &apos;{0}&apos; since it is not read only.
        /// </summary>
        internal static string NotSupportedLoadOfStaticField {
            get {
                return ResourceManager.GetString("NotSupportedLoadOfStaticField", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The local memory intrinsic &apos;{0}&apos; is not supported.
        /// </summary>
        internal static string NotSupportedLocalMemoryIntrinsic {
            get {
                return ResourceManager.GetString("NotSupportedLocalMemoryIntrinsic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The math intrinsic with {0} arguments is not supported.
        /// </summary>
        internal static string NotSupportedMathIntrinsic {
            get {
                return ResourceManager.GetString("NotSupportedMathIntrinsic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not supported jump to method &apos;{0}&apos;.
        /// </summary>
        internal static string NotSupportedMethodJump {
            get {
                return ResourceManager.GetString("NotSupportedMethodJump", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not supported platform &apos;{0}&apos; ({1} required).
        /// </summary>
        internal static string NotSupportedPlatform {
            get {
                return ResourceManager.GetString("NotSupportedPlatform", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pointer type &apos;{0}&apos; is not supported.
        /// </summary>
        internal static string NotSupportedPointerType {
            get {
                return ResourceManager.GetString("NotSupportedPointerType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not supported recursive program.
        /// </summary>
        internal static string NotSupportedRecursiveProgram {
            get {
                return ResourceManager.GetString("NotSupportedRecursiveProgram", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not supported runtime method &apos;{0}&apos;.
        /// </summary>
        internal static string NotSupportedRuntimeMethod {
            get {
                return ResourceManager.GetString("NotSupportedRuntimeMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Shared memory is not supported by implicitly grouped kernels..
        /// </summary>
        internal static string NotSupportedSharedImplicitlyGroupedKernel {
            get {
                return ResourceManager.GetString("NotSupportedSharedImplicitlyGroupedKernel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The shared memory intrinsic &apos;{0}&apos; is not supported.
        /// </summary>
        internal static string NotSupportedSharedMemoryIntrinsic {
            get {
                return ResourceManager.GetString("NotSupportedSharedMemoryIntrinsic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not resolve the native size of the type &apos;{0}&apos;.
        /// </summary>
        internal static string NotSupportedSizeOf {
            get {
                return ResourceManager.GetString("NotSupportedSizeOf", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot store a value to the static field &apos;{0}&apos;.
        /// </summary>
        internal static string NotSupportedStoreToStaticField {
            get {
                return ResourceManager.GetString("NotSupportedStoreToStaticField", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; has an unsupported structure layout.
        /// </summary>
        internal static string NotSupportedStructureLayout {
            get {
                return ResourceManager.GetString("NotSupportedStructureLayout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not supported type &apos;{0}&apos;.
        /// </summary>
        internal static string NotSupportedType {
            get {
                return ResourceManager.GetString("NotSupportedType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The view intrinsic &apos;{0}&apos; is not supported.
        /// </summary>
        internal static string NotSupportedViewIntrinsic {
            get {
                return ResourceManager.GetString("NotSupportedViewIntrinsic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not supported virtual call to method &apos;{0}&apos;.
        /// </summary>
        internal static string NotSupportedVirtualMethodCall {
            get {
                return ResourceManager.GetString("NotSupportedVirtualMethodCall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not supported virtual call to method &apos;{0}&apos; defined in type &apos;{1}&apos; that was called on &apos;{2}&apos;.
        /// </summary>
        internal static string NotSupportedVirtualMethodCallToObject {
            get {
                return ResourceManager.GetString("NotSupportedVirtualMethodCallToObject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Calling the virtual method &apos;{0}&apos; of unconstrained instance is not supported.
        /// </summary>
        internal static string NotSupportedVirtualMethodCallToUnconstrainedInstance {
            get {
                return ResourceManager.GetString("NotSupportedVirtualMethodCallToUnconstrainedInstance", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Void type is not supported.
        /// </summary>
        internal static string NotSupportedVoidType {
            get {
                return ResourceManager.GetString("NotSupportedVoidType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The warp intrinsic &apos;{0}&apos; is not supported.
        /// </summary>
        internal static string NotSupportedWarpIntrinsic {
            get {
                return ResourceManager.GetString("NotSupportedWarpIntrinsic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not supported write format &apos;{0}&apos;.
        /// </summary>
        internal static string NotSupportedWriteFormat {
            get {
                return ResourceManager.GetString("NotSupportedWriteFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not supported write format argument reference &apos;{1}&apos; in &apos;{0}&apos;.
        /// </summary>
        internal static string NotSupportedWriteFormatArgumentRef {
            get {
                return ResourceManager.GetString("NotSupportedWriteFormatArgumentRef", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not supported write format argument type &apos;{1} in &apos;{0}&apos;.
        /// </summary>
        internal static string NotSupportedWriteFormatArgumentType {
            get {
                return ResourceManager.GetString("NotSupportedWriteFormatArgumentType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not supported write format &apos;{0}; must be a constant string reference.
        /// </summary>
        internal static string NotSupportedWriteFormatConstant {
            get {
                return ResourceManager.GetString("NotSupportedWriteFormatConstant", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The array dimension &apos;{0}&apos; must be a compile-time constant and within the range of the array..
        /// </summary>
        internal static string NotSupportNonConstArrayDimension {
            get {
                return ResourceManager.GetString("NotSupportNonConstArrayDimension", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There are no uses to resolve.
        /// </summary>
        internal static string NoUses {
            get {
                return ResourceManager.GetString("NoUses", resourceCulture);
            }
        }
    }
}
