using UnityEngine;
using RRCGBuild;
using System.Collections.Generic;

namespace RRCGBuild
{
    public class Operators : CircuitBuilder
    {
        public override void CircuitGraph()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginAccessibilityScope(false);
            NativeIntOperators();
            NativeFloatOperators();
            PortIntOperators();
            PortFloatOperators();
            VectorOperators();
            MixedOperators();
            TernaryOperator();
            BitwiseOperators();
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        public void NativeIntOperators()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginAccessibilityScope(false);
            new EventDefinition("NativeIntOperators").Receiver();
            IntPort nativeA = __VariableDeclaratorExpression<IntPort>("nativeA", () => 1, (rrcg_setter_value) => nativeA = rrcg_setter_value);
            IntPort nativeB = __VariableDeclaratorExpression<IntPort>("nativeB", () => 2, (rrcg_setter_value) => nativeB = rrcg_setter_value);
            ChipLib.Log(nativeA + nativeB);
            ChipLib.Log(nativeA - nativeB);
            ChipLib.Log(nativeA * nativeB);
            ChipLib.Log(nativeA / nativeB);
            ChipLib.Log(nativeA % nativeB);
            IntPort postIncrement = __VariableDeclaratorExpression<IntPort>("postIncrement", () => 0, (rrcg_setter_value) => postIncrement = rrcg_setter_value);
            ChipLib.Log(postIncrement++);
            ChipLib.Log(postIncrement);
            IntPort preIncrement = __VariableDeclaratorExpression<IntPort>("preIncrement", () => 0, (rrcg_setter_value) => preIncrement = rrcg_setter_value);
            ChipLib.Log(++preIncrement);
            ChipLib.Log(++preIncrement);
            IntPort postDecrement = __VariableDeclaratorExpression<IntPort>("postDecrement", () => 0, (rrcg_setter_value) => postDecrement = rrcg_setter_value);
            ChipLib.Log(postDecrement--);
            ChipLib.Log(postDecrement);
            IntPort preDecrement = __VariableDeclaratorExpression<IntPort>("preDecrement", () => 0, (rrcg_setter_value) => preDecrement = rrcg_setter_value);
            ChipLib.Log(--preDecrement);
            ChipLib.Log(preDecrement);
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        public void NativeFloatOperators()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginAccessibilityScope(false);
            new EventDefinition("NativeFloatOperators").Receiver();
            FloatPort nativeA = __VariableDeclaratorExpression<FloatPort>("nativeA", () => 1, (rrcg_setter_value) => nativeA = rrcg_setter_value);
            FloatPort nativeB = __VariableDeclaratorExpression<FloatPort>("nativeB", () => 2, (rrcg_setter_value) => nativeB = rrcg_setter_value);
            ChipLib.Log(nativeA + nativeB);
            ChipLib.Log(nativeA - nativeB);
            ChipLib.Log(nativeA * nativeB);
            ChipLib.Log(nativeA / nativeB);
            ChipLib.Log(nativeA % nativeB);
            FloatPort postIncrement = __VariableDeclaratorExpression<FloatPort>("postIncrement", () => 0, (rrcg_setter_value) => postIncrement = rrcg_setter_value);
            ChipLib.Log(postIncrement++);
            ChipLib.Log(postIncrement);
            FloatPort preIncrement = __VariableDeclaratorExpression<FloatPort>("preIncrement", () => 0, (rrcg_setter_value) => preIncrement = rrcg_setter_value);
            ChipLib.Log(++preIncrement);
            ChipLib.Log(++preIncrement);
            FloatPort postDecrement = __VariableDeclaratorExpression<FloatPort>("postDecrement", () => 0, (rrcg_setter_value) => postDecrement = rrcg_setter_value);
            ChipLib.Log(postDecrement--);
            ChipLib.Log(postDecrement);
            FloatPort preDecrement = __VariableDeclaratorExpression<FloatPort>("preDecrement", () => 0, (rrcg_setter_value) => preDecrement = rrcg_setter_value);
            ChipLib.Log(--preDecrement);
            ChipLib.Log(preDecrement);
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        public void PortIntOperators()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginAccessibilityScope(false);
            new EventDefinition("PortIntOperators").Receiver();
            IntPort portA = __VariableDeclaratorExpression<IntPort>("portA", () => RandomInt(0, 0), (rrcg_setter_value) => portA = rrcg_setter_value);
            IntPort portB = __VariableDeclaratorExpression<IntPort>("portB", () => RandomInt(0, 0), (rrcg_setter_value) => portB = rrcg_setter_value);
            ChipLib.Log(portA + portB);
            ChipLib.Log(portA - portB);
            ChipLib.Log(portA * portB);
            ChipLib.Log(portA / portB);
            ChipLib.Log(portA % portB);
            IntPort postIncrement = __VariableDeclaratorExpression<IntPort>("postIncrement", () => RandomInt(0, 0), (rrcg_setter_value) => postIncrement = rrcg_setter_value);
            ChipLib.Log(postIncrement++);
            ChipLib.Log(postIncrement);
            IntPort preIncrement = __VariableDeclaratorExpression<IntPort>("preIncrement", () => RandomInt(0, 0), (rrcg_setter_value) => preIncrement = rrcg_setter_value);
            ChipLib.Log(++preIncrement);
            ChipLib.Log(preIncrement);
            IntPort postDecrement = __VariableDeclaratorExpression<IntPort>("postDecrement", () => RandomInt(0, 0), (rrcg_setter_value) => postDecrement = rrcg_setter_value);
            ChipLib.Log(postDecrement--);
            ChipLib.Log(postDecrement);
            IntPort preDecrement = __VariableDeclaratorExpression<IntPort>("preDecrement", () => RandomInt(0, 0), (rrcg_setter_value) => preDecrement = rrcg_setter_value);
            ChipLib.Log(--preDecrement);
            ChipLib.Log(preDecrement);
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        public void PortFloatOperators()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginAccessibilityScope(false);
            new EventDefinition("PortFloatOperators").Receiver();
            FloatPort portA = __VariableDeclaratorExpression<FloatPort>("portA", () => RandomFloat(1, 1), (rrcg_setter_value) => portA = rrcg_setter_value);
            FloatPort portB = __VariableDeclaratorExpression<FloatPort>("portB", () => RandomFloat(2, 2), (rrcg_setter_value) => portB = rrcg_setter_value);
            ChipLib.Log(portA + portB);
            ChipLib.Log(portA - portB);
            ChipLib.Log(portA * portB);
            ChipLib.Log(portA / portB);
            ChipLib.Log(portA % portB);
            FloatPort postIncrement = __VariableDeclaratorExpression<FloatPort>("postIncrement", () => RandomFloat(0, 0), (rrcg_setter_value) => postIncrement = rrcg_setter_value);
            ChipLib.Log(postIncrement++);
            ChipLib.Log(postIncrement);
            FloatPort preIncrement = __VariableDeclaratorExpression<FloatPort>("preIncrement", () => RandomFloat(0, 0), (rrcg_setter_value) => preIncrement = rrcg_setter_value);
            ChipLib.Log(++preIncrement);
            ChipLib.Log(preIncrement);
            FloatPort postDecrement = __VariableDeclaratorExpression<FloatPort>("postDecrement", () => RandomFloat(0, 0), (rrcg_setter_value) => postDecrement = rrcg_setter_value);
            ChipLib.Log(postDecrement--);
            ChipLib.Log(postDecrement);
            FloatPort preDecrement = __VariableDeclaratorExpression<FloatPort>("preDecrement", () => RandomFloat(0, 0), (rrcg_setter_value) => preDecrement = rrcg_setter_value);
            ChipLib.Log(--preDecrement);
            ChipLib.Log(preDecrement);
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        public void VectorOperators()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginAccessibilityScope(false);
            new EventDefinition("VectorOperators").Receiver();
            Vector3Port vectorA = __VariableDeclaratorExpression<Vector3Port>("vectorA", () => Vector3Create(1, 2, 3), (rrcg_setter_value) => vectorA = rrcg_setter_value);
            Vector3Port vectorB = __VariableDeclaratorExpression<Vector3Port>("vectorB", () => Vector3Create(4, 5, 6), (rrcg_setter_value) => vectorB = rrcg_setter_value);
            FloatPort portA = __VariableDeclaratorExpression<FloatPort>("portA", () => RandomFloat(1, 1), (rrcg_setter_value) => portA = rrcg_setter_value);
            IntPort portB = __VariableDeclaratorExpression<IntPort>("portB", () => RandomInt(2, 2), (rrcg_setter_value) => portB = rrcg_setter_value);
            ChipLib.Log(vectorA + vectorB);
            ChipLib.Log(vectorA - vectorB);
            // Should be converted to VectorScale
            ChipLib.Log(vectorA * portA);
            ChipLib.Log(vectorB * portB);
            ChipLib.Log(portA * vectorA);
            ChipLib.Log(portB * vectorB);
            ChipLib.Log(vectorA / portA);
            ChipLib.Log(vectorB / portB);
            // TODO: These will loose their default value in game. Can we detect this?
            ChipLib.Log(vectorA * 5f);
            ChipLib.Log(vectorA * 6);
            ChipLib.Log(7f * vectorB);
            ChipLib.Log(8 * vectorB);
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        public void MixedOperators()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginAccessibilityScope(false);
            new EventDefinition("MixedOperators").Receiver();
            FloatPort portA = __VariableDeclaratorExpression<FloatPort>("portA", () => RandomFloat(1, 1), (rrcg_setter_value) => portA = rrcg_setter_value);
            IntPort portB = __VariableDeclaratorExpression<IntPort>("portB", () => RandomInt(2, 2), (rrcg_setter_value) => portB = rrcg_setter_value);
            FloatPort nativeA = __VariableDeclaratorExpression<FloatPort>("nativeA", () => 3, (rrcg_setter_value) => nativeA = rrcg_setter_value);
            IntPort nativeB = __VariableDeclaratorExpression<IntPort>("nativeB", () => 4, (rrcg_setter_value) => nativeB = rrcg_setter_value);
            ChipLib.Log(portA + portB * nativeA / nativeB);
            ChipLib.Log(portA + portB * 5);
            ChipLib.Log(portA * portB + 5);
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        public void TernaryOperator()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginAccessibilityScope(false);
            new EventDefinition("TernaryOperator").Receiver();
            FloatPort dataA = __VariableDeclaratorExpression<FloatPort>("dataA", () => 0, (rrcg_setter_value) => dataA = rrcg_setter_value);
            FloatPort dataB = __VariableDeclaratorExpression<FloatPort>("dataB", () => 1, (rrcg_setter_value) => dataB = rrcg_setter_value);
            ChipLib.EventCache<FloatPort>(ChipBuilder.IfValue<FloatPort>(true, dataA, dataB));
            FloatPort portA = __VariableDeclaratorExpression<FloatPort>("portA", () => RandomFloat(0, 0), (rrcg_setter_value) => portA = rrcg_setter_value);
            FloatPort portB = __VariableDeclaratorExpression<FloatPort>("portB", () => RandomFloat(1, 1), (rrcg_setter_value) => portB = rrcg_setter_value);
            ChipLib.EventCache<FloatPort>(ChipBuilder.IfValue<FloatPort>(true, portA, portB));
            // Port / data
            ChipLib.EventCache<FloatPort>(ChipBuilder.IfValue<FloatPort>(true, portA, dataB));
            // Implicit conversions
            // Floats without -f suffix
            RandomFloat(0, ChipBuilder.IfValue<FloatPort>(true, 123, 456));
            IntPort intPort = __VariableDeclaratorExpression<IntPort>("intPort", () => RandomInt(0, 0), (rrcg_setter_value) => intPort = rrcg_setter_value);
            RandomFloat(0, ChipBuilder.IfValue<FloatPort>(true, 1.5f, intPort));
            // Implicit conversion for result
            ChipLib.Log(__StringInterpolation("Result: ", (ChipBuilder.IfValue<FloatPort>(false, intPort, portA))));
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        public void BitwiseOperators()
        {
            ExecFlow rrcg_return_flow = new ExecFlow();
            __BeginAccessibilityScope(false);
            new EventDefinition("BitwiseOperators").Receiver();
            IntPort dataA = __VariableDeclaratorExpression<IntPort>("dataA", () => BinaryLiteral(0b00000000000011111111111111111111), (rrcg_setter_value) => dataA = rrcg_setter_value);
            IntPort dataB = __VariableDeclaratorExpression<IntPort>("dataB", () => BinaryLiteral(0b11111111111111111111000000000000), (rrcg_setter_value) => dataB = rrcg_setter_value);
            IntPort portA = __VariableDeclaratorExpression<IntPort>("portA", () => Reroute<IntPort>(dataA), (rrcg_setter_value) => portA = rrcg_setter_value);
            ChipLib.Log(__StringInterpolation("Bitwise AND, pure data: ", ChipLib.BitString(dataA & dataB)));
            ChipLib.Log(__StringInterpolation("Bitwise AND, with ports: ", ChipLib.BitString(portA & dataB)));
            ChipLib.Log(__StringInterpolation("Bitwise OR, pure data: ", ChipLib.BitString(dataA | dataB)));
            ChipLib.Log(__StringInterpolation("Bitwise OR, with ports: ", ChipLib.BitString(portA | dataB)));
            ChipLib.Log(__StringInterpolation("Bitwise XOR, pure data: ", ChipLib.BitString(dataA ^ dataB)));
            ChipLib.Log(__StringInterpolation("Bitwise XOR, with ports: ", ChipLib.BitString(portA ^ dataB)));
            IntPort dataC = __VariableDeclaratorExpression<IntPort>("dataC", () => BinaryLiteral(0b00000000000011111111000000000000), (rrcg_setter_value) => dataC = rrcg_setter_value);
            IntPort portC = __VariableDeclaratorExpression<IntPort>("portC", () => Reroute<IntPort>(dataC), (rrcg_setter_value) => portC = rrcg_setter_value);
            ChipLib.Log(__StringInterpolation("Bit shift left, pure data: ", ChipLib.BitString(ChipBuilder.BitShiftLeft(dataC, 12))));
            ChipLib.Log(__StringInterpolation("Bit shift left, with ports: ", ChipLib.BitString(ChipBuilder.BitShiftLeft(portC, 12))));
            ChipLib.Log(__StringInterpolation("Bit shift right, pure data: ", ChipLib.BitString(ChipBuilder.BitShiftRight(dataC, 12))));
            ChipLib.Log(__StringInterpolation("Bit shift right, with ports: ", ChipLib.BitString(ChipBuilder.BitShiftRight(portC, 12))));
            IntPort dataD = __VariableDeclaratorExpression<IntPort>("dataD", () => BinaryLiteral(0b_0000_1111_0000_1111_0000_1111_0000_1100), (rrcg_setter_value) => dataD = rrcg_setter_value);
            IntPort portD = __VariableDeclaratorExpression<IntPort>("portD", () => Reroute<IntPort>(dataD), (rrcg_setter_value) => portD = rrcg_setter_value);
            ChipLib.Log(__StringInterpolation("Bitwise complement, pure data: ", ChipLib.BitString(~dataD)));
            ChipLib.Log(__StringInterpolation("Bitwise complement, with ports: ", ChipLib.BitString(~portD)));
            ExecFlow.current.Clear();
            __EndAccessibilityScope();
            ExecFlow.current.Merge(rrcg_return_flow);
        }

        int BinaryLiteral(uint literal)
        {
            return unchecked((int)literal);
        }
    }
}