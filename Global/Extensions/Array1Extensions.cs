﻿using System;
using System.Collections.Generic;

public static class Array1Extensions
{
    public static bool ValidateIndex<T>(this T[] self, int index)
        => self != null && index >= 0 && index < self.Length;

    public static ReadArray1<T> AsReadArray<T>(this T[] self)
        => self;

    public static T Get<T>(this object[] self, int index)
    {
        if (self == null)
            return default;

        return self.Length > index && self[index] is T val ? val : default;
    }

    public static object[] Get<T>(this object[] self, int index, out T value)
    {
        value = default;

        if (self != null && self.Length > index && self[index] is T val)
            value = val;

        return self;
    }

    public static object[] GetThenMoveNext<T>(this object[] self, ref int index, out T value)
    {
        value = default;

        if (self != null)
        {
            if (self.Length > index && self[index] is T val)
                value = val;

            index += 1;
        }

        return self;
    }

    public static T[] Get<T, TResult>(this T[] self, int index, out TResult value)
    {
        value = default;

        if (self != null && self.Length > index && self[index] is TResult val)
            value = val;

        return self;
    }

    public static T[] GetThenMoveNext<T, TResult>(this T[] self, ref int index, out TResult value)
    {
        value = default;

        if (self != null)
        {
            if (self.Length > index && self[index] is TResult val)
                value = val;

            index += 1;
        }

        return self;
    }

    public static void Clear<T>(this T[] self)
    {
        if (self == null)
            return;

        for (var i = 0; i < self.Length; i++)
        {
            self[i] = default;
        }
    }

    public static void Set<T>(this T[] self, params T[] source)
        => self.Set(0, source);

    public static void Set<T>(this T[] self, int startIndex, params T[] source)
    {
        if (self == null || source == null)
            return;

        var length = Math.Min(self.Length, source.Length);

        for (var i = startIndex; i < length; i++)
        {
            self[i] = source[i];
        }
    }

    public static void Set<T>(this T[] self, IList<T> source)
        => self.Set(0, source);

    public static void Set<T>(this T[] self, int startIndex, IList<T> source)
        => self.Set(startIndex, source.AsSegment());

    public static void Set<T>(this T[] self, IReadOnlyList<T> source)
        => self.Set(0, source);

    public static void Set<T>(this T[] self, int startIndex, IReadOnlyList<T> source)
        => self.Set(startIndex, source.AsSegment());

    public static void Set<T>(this T[] self, in Segment<T> source)
        => self.Set(0, in source);

    public static void Set<T>(this T[] self, int startIndex, in Segment<T> source)
    {
        if (self == null)
            return;

        var length = Math.Min(self.Length, source.Count);

        for (var i = startIndex; i < length; i++)
        {
            self[i] = source[i];
        }
    }

    public static void Set<T>(this T[] self, IEnumerable<T> source)
        => self.Set(0, source);

    public static void Set<T>(this T[] self, int startIndex, IEnumerable<T> source)
    {
        if (self == null || source == null)
            return;

        var index = startIndex;

        foreach (var value in source)
        {
            if (!self.ValidateIndex(index))
                break;

            self[index++] = value;
        }
    }

    public static void GetRange<T>(this T[] self, in ReadRange<int> range, ICollection<T> output, bool allowDuplicate = true, bool allowNull = false)
    {
        var start = Math.Min(range.Start, range.End);
        var end = Math.Max(range.Start, range.End);

        self.GetRange(start + 1, end - start, output, allowDuplicate, allowNull);
    }

    public static void GetRange<T>(this T[] self, int offset, ICollection<T> output, bool allowDuplicate = true, bool allowNull = false)
        => self.GetRange(offset, -1, output, allowDuplicate, allowNull);

    public static void GetRange<T>(this T[] self, int offset, int count, ICollection<T> output, bool allowDuplicate = true, bool allowNull = false)
    {
        if (self == null || output == null || count == 0)
            return;

        offset = Math.Max(offset, 0);

        if (offset > self.Length)
            throw new IndexOutOfRangeException(nameof(offset));

        if (count < 0)
            count = self.Length - offset;
        else
            count += offset;

        if (count > self.Length)
            throw new IndexOutOfRangeException(nameof(count));

        for (var i = offset; i < count; i++)
        {
            output.Add(self[i]);
        }
    }
}