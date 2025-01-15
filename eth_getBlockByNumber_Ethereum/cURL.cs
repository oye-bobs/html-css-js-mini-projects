curl https://eth-mainnet.g.alchemy.com/v2/your-api-key \
    -X POST \
    -H "Content-Type: application/json" \
    -d '{"jsonrpc":"2.0","method":"eth_getBlockByNumber","params":["latest", true],"id":1}'