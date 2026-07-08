class Solution {
public:

    bool binarySearch(vector<int> nums, int tar)
    {
        int n=nums.size();
        int low=0, high=n-1;
        int mid;
        while(low<=high)
        {
            mid=(low+high)/2;
            if(nums[mid]==tar) return true;
            else if (nums[mid]<tar) low=mid+1;
            else high=mid-1;
        }
        return false;
    }
    bool searchMatrix(vector<vector<int>>& matrix, int target) {
       int row=matrix.size();
       int col=matrix[0].size();
       for(int i=0;i<row;i++)
       {
        if(matrix[i][0]<=target && matrix[i][col-1]>=target)
          return binarySearch(matrix[i],target);
       } 
       return false;
    }
};
