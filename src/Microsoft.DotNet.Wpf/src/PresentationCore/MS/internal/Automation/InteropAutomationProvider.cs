// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;

namespace MS.Internal.Automation
{
    internal class InteropAutomationProvider: IRawElementProviderFragmentRoot
    {
        #region Constructors

        internal InteropAutomationProvider(HostedWindowWrapper wrapper, AutomationPeer parent)
        {
            ArgumentNullException.ThrowIfNull(wrapper);
            ArgumentNullException.ThrowIfNull(parent);

            _wrapper = wrapper;
            _parent = parent;
        }
        
        #endregion Constructors

        #region IRawElementProviderSimple
        
        ///
        ProviderOptions IRawElementProviderSimple.ProviderOptions
        {
            get { return ProviderOptions.ServerSideProvider | ProviderOptions.OverrideProvider; }
        }

        ///
        object IRawElementProviderSimple.GetPatternProvider(int patternId)
        {
            return null;
        }

        ///
        object IRawElementProviderSimple.GetPropertyValue(int propertyId)
        {
            return null;
        }

        IRawElementProviderSimple IRawElementProviderSimple.HostRawElementProvider
        {
            get
            {
                return AutomationInteropProvider.HostProviderFromHandle(_wrapper.Handle);
            }
        }

        #endregion IRawElementProviderSimple

        #region IRawElementProviderFragment

        IRawElementProviderFragment IRawElementProviderFragment.Navigate(NavigateDirection direction)
        {
            if (direction == NavigateDirection.Parent)
            {
                return (IRawElementProviderFragment)_parent.ProviderFromPeer(_parent);
            }

            return null;
        }

        ///
        int [] IRawElementProviderFragment.GetRuntimeId()
        {
            return null;
        }

        ///
        Rect IRawElementProviderFragment.BoundingRectangle
        {
            get { return Rect.Empty; }
        }

        ///
        IRawElementProviderSimple [] IRawElementProviderFragment.GetEmbeddedFragmentRoots()
        {
            return null;
        }

        ///        
        void IRawElementProviderFragment.SetFocus()
        {
            throw new NotSupportedException();
        }

        ///
        IRawElementProviderFragmentRoot IRawElementProviderFragment.FragmentRoot
        {
            get { return null; }
        }
        
        #endregion IRawElementProviderFragment

        #region IRawElementProviderFragmentRoot

        ///
        IRawElementProviderFragment IRawElementProviderFragmentRoot.ElementProviderFromPoint( double x, double y )
        {
            return null;
        }

        ///
        IRawElementProviderFragment IRawElementProviderFragmentRoot.GetFocus()
        {
            return null;
        }

        #endregion IRawElementProviderFragmentRoot

        #region Data

        private HostedWindowWrapper         _wrapper;
        private AutomationPeer              _parent;

        #endregion Data
    }
}

