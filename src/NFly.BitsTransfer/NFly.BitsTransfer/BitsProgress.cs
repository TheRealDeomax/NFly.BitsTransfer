// MIT License 2016 joylei(leingliu@126.com)
namespace NFly.BitsTransfer
{
    public struct BitsProgress
    {
        public BitsJob Job;

        /// <summary>
        /// total bytes
        /// </summary>
        public long BytesTotal;

        /// <summary>
        /// transferred bytes
        /// </summary>
        public long BytesTransferred;

        /// <summary>
        /// remaining bytes
        /// </summary>
        public long BytesRemaining;

        /// <summary>
        /// bytes per second
        /// </summary>
        public long EstimatedSpeed;

        /// <summary>
        /// in seconds
        /// </summary>
        public long EstimatedTimeRemaining;

        public float Percentage;
    }
}