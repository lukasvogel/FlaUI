﻿using FlaUI.Core.AutomationElements.Infrastructure;
using FlaUI.Core.Identifiers;
using FlaUI.UIA2.Identifiers;

namespace FlaUI.UIA2
{
    public class UIA2AutomationElementPatternAvailabilityProperties : IAutomationElementPatternAvailabilityProperties
    {
        public PropertyId IsAnnotationPatternAvailable => PropertyId.NotSupportedByFramework;
        public PropertyId IsDockPatternAvailable => AutomationObjectIds.IsDockPatternAvailableProperty;
        public PropertyId IsDragPatternAvailable => PropertyId.NotSupportedByFramework;
        public PropertyId IsDropTargetPatternAvailable => PropertyId.NotSupportedByFramework;
        public PropertyId IsExpandCollapsePatternAvailable => AutomationObjectIds.IsExpandCollapsePatternAvailableProperty;
        public PropertyId IsGridItemPatternAvailable => AutomationObjectIds.IsGridItemPatternAvailableProperty;
        public PropertyId IsGridPatternAvailable => AutomationObjectIds.IsGridPatternAvailableProperty;
        public PropertyId IsInvokePatternAvailable => AutomationObjectIds.IsInvokePatternAvailableProperty;
#if NET35
        public PropertyId IsItemContainerPatternAvailable => PropertyId.NotSupportedByFramework;
#else
        public PropertyId IsItemContainerPatternAvailable => AutomationObjectIds.IsItemContainerPatternAvailableProperty;
#endif
        public PropertyId IsLegacyIAccessiblePatternAvailable => PropertyId.NotSupportedByFramework;
        public PropertyId IsMultipleViewPatternAvailable => AutomationObjectIds.IsMultipleViewPatternAvailableProperty;
        public PropertyId IsObjectModelPatternAvailable => PropertyId.NotSupportedByFramework;
        public PropertyId IsRangeValuePatternAvailable => AutomationObjectIds.IsRangeValuePatternAvailableProperty;
        public PropertyId IsScrollItemPatternAvailable => AutomationObjectIds.IsScrollItemPatternAvailableProperty;
        public PropertyId IsScrollPatternAvailable => AutomationObjectIds.IsScrollPatternAvailableProperty;
        public PropertyId IsSelectionItemPatternAvailable => AutomationObjectIds.IsSelectionItemPatternAvailableProperty;
        public PropertyId IsSelectionPatternAvailable => AutomationObjectIds.IsSelectionPatternAvailableProperty;
        public PropertyId IsSpreadsheetPatternAvailable => PropertyId.NotSupportedByFramework;
        public PropertyId IsSpreadsheetItemPatternAvailable => PropertyId.NotSupportedByFramework;
        public PropertyId IsStylesPatternAvailable => PropertyId.NotSupportedByFramework;
#if NET35
        public PropertyId IsSynchronizedInputPatternAvailable => PropertyId.NotSupportedByFramework;
#else
        public PropertyId IsSynchronizedInputPatternAvailable => AutomationObjectIds.IsSynchronizedInputPatternAvailableProperty;
#endif
        public PropertyId IsTableItemPatternAvailable => AutomationObjectIds.IsTableItemPatternAvailableProperty;
        public PropertyId IsTablePatternAvailable => AutomationObjectIds.IsTablePatternAvailableProperty;
        public PropertyId IsTextChildPatternAvailable => PropertyId.NotSupportedByFramework;
        public PropertyId IsTextEditPatternAvailable => PropertyId.NotSupportedByFramework;
        public PropertyId IsTextPatternAvailable => AutomationObjectIds.IsTextPatternAvailableProperty;
        public PropertyId IsTextPattern2Available => PropertyId.NotSupportedByFramework;
        public PropertyId IsTogglePatternAvailable => AutomationObjectIds.IsTogglePatternAvailableProperty;
        public PropertyId IsTransformPatternAvailable => AutomationObjectIds.IsTransformPatternAvailableProperty;
        public PropertyId IsTransformPattern2Available => PropertyId.NotSupportedByFramework;
        public PropertyId IsValuePatternAvailable => AutomationObjectIds.IsValuePatternAvailableProperty;
#if NET35
        public PropertyId IsVirtualizedItemPatternAvailable => PropertyId.NotSupportedByFramework;
#else
        public PropertyId IsVirtualizedItemPatternAvailable => AutomationObjectIds.IsVirtualizedItemPatternAvailableProperty;
#endif
        public PropertyId IsWindowPatternAvailable => AutomationObjectIds.IsWindowPatternAvailableProperty;

        public PropertyId[] AllForCurrentFramework => new[] {
            IsDockPatternAvailable,
            IsExpandCollapsePatternAvailable,
            IsGridItemPatternAvailable,
            IsGridPatternAvailable,
            IsInvokePatternAvailable,
#if !NET35
            IsItemContainerPatternAvailable,
#endif
            IsMultipleViewPatternAvailable,
            IsRangeValuePatternAvailable,
            IsScrollItemPatternAvailable,
            IsScrollPatternAvailable,
            IsSelectionItemPatternAvailable,
            IsSelectionPatternAvailable,
#if !NET35
            IsSynchronizedInputPatternAvailable,
#endif
            IsTableItemPatternAvailable,
            IsTablePatternAvailable,
            IsTextPatternAvailable,
            IsTogglePatternAvailable,
            IsTransformPatternAvailable,
            IsValuePatternAvailable,
#if !NET35
            IsVirtualizedItemPatternAvailable,
#endif
            IsWindowPatternAvailable
        };
    }
}