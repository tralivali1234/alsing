﻿namespace QI4N.Framework.Runtime
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    using Bootstrap;

    [DebuggerDisplay("Name {Name}")]
    public class ModuleAssemblyImpl : ModuleAssembly
    {
        private readonly IList<EntityDeclaration> entityDeclarations = new List<EntityDeclaration>();

        private readonly string name;

        private readonly IList<ServiceDeclaration> serviceDeclarations = new List<ServiceDeclaration>();

        private readonly IList<TransientDeclaration> transientDeclarations = new List<TransientDeclaration>();

        private readonly IList<ValueDeclaration> valueDeclarations = new List<ValueDeclaration>();

        private LayerAssembly layerAssembly;

        public ModuleAssemblyImpl(LayerAssembly layerAssembly, string name)
        {
            this.layerAssembly = layerAssembly;
            this.name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public EntityDeclaration AddEntities()
        {
            var declaration = new EntityDeclarationImpl();
            this.entityDeclarations.Add(declaration);
            return declaration;
        }

        public ServiceDeclaration AddServices()
        {
            var declaration = new ServiceDeclarationImpl();
            this.serviceDeclarations.Add(declaration);
            return declaration;
        }

        public TransientDeclaration AddTransients()
        {
            var declaration = new TransientDeclarationImpl();
            this.transientDeclarations.Add(declaration);
            return declaration;
        }

        public ValueDeclaration AddValues()
        {
            var declaration = new ValueDeclarationImpl();
            this.valueDeclarations.Add(declaration);
            return declaration;
        }

        public void Visit(AssemblyVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}