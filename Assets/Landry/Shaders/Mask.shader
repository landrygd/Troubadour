Shader "Custom/Mask"
{
	// Mask shader
	SubShader 
	{
		Tags {
			"Queue" = "Transparent+1"
		}
		
		Pass {
			Blend Zero One
		}
	}
}
