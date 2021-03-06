﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.
using UnityEngine;

namespace Adept.Unity
{
    /// <summary>
    /// Represents a binding between a data item and another item.
    /// </summary>
    [AddComponentMenu("Binding/Data Binding", 51)]
    public class DataBinding : BindingBase
    {
        #region Serialized Variables
        [SerializeField]
        [Tooltip("The name of the source member (property or field) that will participate in the binding.")]
        private string _sourceMemberName; // Inspector only.

        [SerializeField]
        [Tooltip("The item that is the target of the binding.")]
        private Component _target; // Inspector only. Stored as Object in Source property during Initialize

        [SerializeField]
        [Tooltip("The name of the target member (property or field) that will participate in the binding.")]
        private string _targetMemberName; // Inspector only.
        #endregion // Serialized Variables

        #region Overrides / Event Handlers
        protected override void Awake()
        {
            // Convert inspector values to property values
            SourceMemberName = _sourceMemberName;
            TargetMemberName = _targetMemberName;
            Target = _target;

            // Pass to base
            base.Awake();
        }
        #endregion // Overrides / Event Handlers
    }
}
