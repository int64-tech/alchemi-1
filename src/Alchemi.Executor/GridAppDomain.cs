#region Alchemi copyright and license notice

/*
* Alchemi [.NET Grid Computing Framework]
* http://www.alchemi.net
*
* Title			:	GridAppDomain.cs
* Project		:	Alchemi Core
* Created on	:	2003
* Copyright		:	Copyright � 2006 The University of Melbourne
*					This technology has been developed with the support of 
*					the Australian Research Council and the University of Melbourne
*					research grants as part of the Gridbus Project
*					within GRIDS Laboratory at the University of Melbourne, Australia.
* Author         :  Akshay Luther (akshayl@csse.unimelb.edu.au) and Rajkumar Buyya (raj@csse.unimelb.edu.au)
* License        :  GPL
*					This program is free software; you can redistribute it and/or 
*					modify it under the terms of the GNU General Public
*					License as published by the Free Software Foundation;
*					See the GNU General Public License 
*					(http://www.gnu.org/copyleft/gpl.html) for more details.
*
*/ 
#endregion

using System;
using System.Reflection;

using Alchemi.Executor.Sandbox;

namespace Alchemi.Executor
{
	/// <summary>
	/// This class is a container for the AppDomainExecutor and AppDomain.
	/// </summary>
    internal class GridAppDomain
    {        
        #region Constructor
        /// <summary>
        /// Initialises a new instance of the GridAppDomain with the given AppDomain and AppDomainExecutor
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="executor"></param>
        internal GridAppDomain(AppDomain domain, AppDomainExecutor executor)
        {
            _Domain = domain;
            _Executor = executor;
        } 
        #endregion      



        #region Property - Domain
        private AppDomain _Domain;
        /// <summary>
        /// Gets the AppDomain
        /// </summary>
        internal AppDomain Domain
        {
            get { return _Domain; }
        } 
        #endregion


        #region Property - Executor
        private AppDomainExecutor _Executor;
        /// <summary>
        /// Gets the AppDommainExecutor
        /// </summary>
        internal AppDomainExecutor Executor
        {
            get { return _Executor; }
        } 
        #endregion

    }
}