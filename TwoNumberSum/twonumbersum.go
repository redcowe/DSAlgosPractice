package main

import "fmt"

func TwoNumberSum(array []int, target int) []int {
	result := []int{}
	for i := 0; i < len(array); i++ {
		for j := i + 1; j < len(array); j++ {
			if array[i]+array[j] == target {
				result = append(result, array[i], array[j])
				break
			}
		}
	}
	return result
}

func main() {
	array := []int{3, 5, -4, 8, 11, 1, -1, 6}
	target := 10
	fmt.Println(TwoNumberSum(array, target))
}
