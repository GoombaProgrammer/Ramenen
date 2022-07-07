using System;
using System.ComponentModel;
using System.Diagnostics;

namespace Ramenen_For_Work.My {
    internal static partial class MyProject {
        internal partial class MyForms {

            [EditorBrowsable(EditorBrowsableState.Never)]
            public cder m_cder;

            public cder cder {
                [DebuggerHidden]
                get {
                    m_cder = Create__Instance__(m_cder);
                    return m_cder;
                }
                [DebuggerHidden]
                set {
                    if (ReferenceEquals(value, m_cder))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_cder);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public MDIParent1 m_MDIParent1;

            public MDIParent1 MDIParent1 {
                [DebuggerHidden]
                get {
                    m_MDIParent1 = Create__Instance__(m_MDIParent1);
                    return m_MDIParent1;
                }
                [DebuggerHidden]
                set {
                    if (ReferenceEquals(value, m_MDIParent1))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_MDIParent1);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Notepad m_Notepad;

            public Notepad Notepad {
                [DebuggerHidden]
                get {
                    m_Notepad = Create__Instance__(m_Notepad);
                    return m_Notepad;
                }
                [DebuggerHidden]
                set {
                    if (ReferenceEquals(value, m_Notepad))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Notepad);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Oops m_Oops;

            public Oops Oops {
                [DebuggerHidden]
                get {
                    m_Oops = Create__Instance__(m_Oops);
                    return m_Oops;
                }
                [DebuggerHidden]
                set {
                    if (ReferenceEquals(value, m_Oops))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Oops);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public SplashScreen1 m_SplashScreen1;

            public SplashScreen1 SplashScreen1 {
                [DebuggerHidden]
                get {
                    m_SplashScreen1 = Create__Instance__(m_SplashScreen1);
                    return m_SplashScreen1;
                }
                [DebuggerHidden]
                set {
                    if (ReferenceEquals(value, m_SplashScreen1))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_SplashScreen1);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Update m_Update;

            public Update Update {
                [DebuggerHidden]
                get {
                    m_Update = Create__Instance__(m_Update);
                    return m_Update;
                }
                [DebuggerHidden]
                set {
                    if (ReferenceEquals(value, m_Update))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Update);
                }
            }

        }


    }
}