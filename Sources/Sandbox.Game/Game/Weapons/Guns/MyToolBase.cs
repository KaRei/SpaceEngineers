﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VRage.Utils;
using VRageMath;

namespace Sandbox.Game.Weapons
{
    public class MyToolBase : MyDeviceBase
    {
        #region Fields
        protected Vector3 m_positionMuzzleLocal;
        protected Vector3D m_positionMuzzleWorld;
        #endregion

        public MyToolBase(Vector3 localMuzzlePosition, MatrixD matrix)
        {
            m_positionMuzzleLocal = localMuzzlePosition;
            OnWorldPositionChanged(matrix);
        }

        public void OnWorldPositionChanged(MatrixD matrix)
        {
            m_positionMuzzleWorld = Vector3D.Transform(m_positionMuzzleLocal, matrix);
        }

        public override bool CanSwitchAmmoMagazine()
        {
            return false;
        }

        public override bool SwitchToNextAmmoMagazine()
        {
            MyDebug.AssertDebug(false, "Switch ammo in MyToolBase, tell MichalW");
            return false;
        }

        public override bool SwitchAmmoMagazineToNextAvailable()
        {
            MyDebug.AssertDebug(false, "Switch ammo in MyToolBase, tell MichalW");
            return false;
        }

        public override Vector3D GetMuzzleLocalPosition()
        {
            return m_positionMuzzleLocal;
        }

        public override Vector3D GetMuzzleWorldPosition()
        {
            return m_positionMuzzleWorld;
        }
    }
}
