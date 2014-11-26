
float Threshold : register(C0);


sampler2D implicitInputSampler : register(S0);


float4 main(float2 uv : TEXCOORD) : COLOR
{
    // Look up the original image color.
    float4 c = tex2D(implicitInputSampler, uv);

    // Adjust it to keep only values brighter than the specified threshold.
    return saturate((c - Threshold) / (1 - Threshold));
}

technique Technique1
{
    pass Pass1
    {
		
        PixelShader = compile ps_3_0 main();
    }
}

