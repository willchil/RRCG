﻿using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using System.Linq;
using Microsoft.CodeAnalysis.Formatting;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;
using System;

namespace RRCG
{
    public class RRCGSyntaxRewriter : CSharpSyntaxRewriter
    {
        private SemanticModel SemanticModel { get; }

        private CircuitDescriptorRewriter circuitDescriptorRewriter;
        private CircuitDescriptorRewriter studioObjectDescriptorRewriter;

        public RRCGSyntaxRewriter(SemanticModel semanticModel)
        {
            SemanticModel = semanticModel;

            circuitDescriptorRewriter = new CircuitDescriptorRewriter(this);
            studioObjectDescriptorRewriter = new CircuitDescriptorRewriter(this);
        }

        //
        // Class and Module
        // 

        public override SyntaxNode VisitCompilationUnit(CompilationUnitSyntax node)
        {
            if (!node.Usings.Any(u => u.Name.ToString() == "RRCGSource"))
            {
                node.RemoveNode(node.Usings.First(u => u.Name.ToString() == "RRCGSource"), SyntaxRemoveOptions.KeepNoTrivia);
            }

            if (!node.Usings.Any(u => u.Name.ToString() == "RRCGBuild"))
            {
                node = node.AddUsings(UsingDirective(ParseName("RRCGBuild")).WithAdditionalAnnotations(Formatter.Annotation));
            }

            if (!node.Usings.Any(u => u.Name.ToString() == "System.Collections.Generic"))
            {
                node = node.AddUsings(UsingDirective(ParseName("System.Collections.Generic")).WithAdditionalAnnotations(Formatter.Annotation));
            }

            var compiled = (CompilationUnitSyntax)base.VisitCompilationUnit(node);

            return compiled.WithMembers(SingletonList<MemberDeclarationSyntax>(
                NamespaceDeclaration(IdentifierName("RRCGBuild"))
                .WithMembers(compiled.Members)
            ));
        }

        public override SyntaxNode VisitUsingDirective(UsingDirectiveSyntax node)
        {
            if (node.Name.ToString() == "RRCGSource")
            {
                return null;
            }
            return base.VisitUsingDirective(node);
        }

        public override SyntaxNode VisitNamespaceDeclaration(NamespaceDeclarationSyntax node)
        {
            throw new Exception("Namespaces are not allowed in RRCG files. They are reserved for the compiler");
        }

        public override SyntaxNode VisitClassDeclaration(ClassDeclarationSyntax node)
        {
            if (node.BaseList.Types.Any(t => t.ToString() == "StudioObjectDescriptor")) return studioObjectDescriptorRewriter.VisitClassDeclarationRoot(node);

            return circuitDescriptorRewriter.VisitClassDeclarationRoot(node);
        }
    }
}
