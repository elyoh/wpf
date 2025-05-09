// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.



/***************************************************************************\
*
*
* Purpose:  Provides an IComponentConnector which is used in instantiation
*           of optimized template content.
*
*
\***************************************************************************/

namespace System.Windows.Markup
{
    // This class provides an IComponentConnector implementation for use during instantiation
    // of optimized template content.  It is given an IComponentConnector, and most calls are
    // just forwarded to it.  But it is also given an IStyleConnector, and calls to Connect
    // are sent there instead.

    internal class TemplateComponentConnector : IComponentConnector
    {
        internal TemplateComponentConnector( IComponentConnector componentConnector, IStyleConnector styleConnector )
        {
            _styleConnector = styleConnector;
            _componentConnector = componentConnector;
        }

        
        public void InitializeComponent()
        {
            _componentConnector.InitializeComponent();
        }

        public void Connect(int connectionId, object target)
        {
            // Calls to IComponentConnector.Connect from template content get forwarded
            // to the outer style connector (when we have one).
            if (_styleConnector != null)
            {
                _styleConnector.Connect(connectionId, target);
            }
            else
            {
                _componentConnector.Connect(connectionId, target);
            }
        }

        private IStyleConnector _styleConnector;
        private IComponentConnector _componentConnector;
    }
}

